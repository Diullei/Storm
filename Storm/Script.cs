using System;
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

        private static dynamic Parse(string source, bool debugMode)
        {
            dynamic tree = null;
            try
            {
                tree = new Esprima.NET.Esprima().Parse(new CsCodeGeneration(debugMode), source);
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

        public static Script Compile(Code code, Context context, string source, IDebugger debugger)
        {
            var csCode = GetCsCode(code, Parse(source, debugger != null));
            Assembly asm = CSScript.LoadCode(csCode);
            var type = asm.GetType("C0");

            if (context.Scope.Obj == null)
                context.Scope.Obj = (JsObject)Activator.CreateInstance(type, debugger);

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