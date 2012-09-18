using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CSScriptLibrary;
using Esprima.NET.Ex;

namespace Storm
{
    public class Script
    {
        private readonly Context _context;

        private Script(Context context)
        {
            _context = context;
        }

        private static dynamic Parse(string source, bool debugMode, Context context)
        {
            dynamic tree = null;
            try
            {
                /*if(context.Scope.Obj != null)
                {
                    source = string.Format("(function(){{{0}}})();", source);
                }*/

                tree = new Esprima.NET.Esprima().Parse(new CsCodeGeneration(debugMode, context), source);
            }
            catch (Esprima.NET.Esprima.Error ex)
            {
                if (ex.Message.Contains("Invalid left-hand side in assignment"))
                    throw new ReferenceError(ex.Message);
                throw new SyntaxError(ex.Message);
            }

            return tree;
        }

        private static string GetCsCode(Code code, dynamic tree)
        {
            return code.GetCsCode(tree);
        }

        public static Script Compile(Code code, Context context, string source)
        {
            return Compile(code, context, source, null);
        }

        private static void CloneProperties(Context context, JsObject original, JsObject target)
        {
            if (original != null)
            {
                context.DeclaredVarNames.ForEach(v =>
                {
                    var originalProperty = original.GetType().GetProperty(v, BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
                    var targetProperty = target.GetType().GetProperty(v, BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
                    if (targetProperty != null)
                    {
                        if (originalProperty != null)
                            targetProperty.SetValue(target, originalProperty.GetValue(original));
                    }
                    else
                    {
                        if (originalProperty != null)
                            target.DynamicProperties[v] = originalProperty.GetValue(original);
                    }
                });
            }
        }

        private static Dictionary<string, JsObject> _cache = new Dictionary<string, JsObject>(); 

        public static Script Compile(Code code, Context context, string source, IDebugger debugger)
        {
            if (debugger != null) debugger.SetSourceCode(source);

            context.SetFunction("eval", (string c) =>
                                            {
                                                var bkCode = source;
                                                var scope = context.Scope;
                                                context.Scope = new Scope {Obj = scope.Obj};
                                                var result = Compile(code, context, c, debugger).Run();

                                                CloneProperties(context, context.Scope.Obj, scope.Obj);

                                                context.Scope = scope;

                                                if (debugger != null) debugger.SetSourceCode(bkCode);

                                                return result;
                                            });

            JsObject instance = null;

            if (!_cache.ContainsKey(source))
            {
                var csCode = GetCsCode(code, Parse(source, debugger != null, context));
                Assembly asm = CSScript.LoadCode(csCode);
                var type = asm.GetType("C0");
                var args = new List<object>();
                context.Actions.ToList().ForEach(a => args.Add(a.Value));
                args.Add(debugger);
                instance = (JsObject) Activator.CreateInstance(type, args.ToArray());

                _cache[source] = instance;
            }
            else
            {
                instance = _cache[source];
            }

            CloneProperties(context, context.Scope.Obj, instance);

            context.Scope.Obj = instance;

            return new Script(context);
        }

        public object Run()
        {
            object result = _context.Scope.Obj.Exec();
            if (OnFinish != null)
                OnFinish(null, null);
            return result;
        }

        public event EventHandler<EventArgs> OnFinish;
    }
}