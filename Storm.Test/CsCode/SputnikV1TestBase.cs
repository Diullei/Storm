using System;
using System.IO;
using System.Reflection;
using Esprima.NET.Ex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Storm.Test.CsCode
{
    [TestClass]
    public class SputnikV1TestBase
    {
        protected Context Context { get; set; }
        protected Code CodeGenerator { get; set; }

        [TestInitialize]
        public void Setup()
        {
            Context = new Context(new Scope());
            CodeGenerator = new Code();
            Context.SetFunction<string>("$ERROR", (message) => { throw new Exception(message); });
        }

        protected static string GetResource(string path)
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                return new StreamReader(assembly.GetManifestResourceStream(path)).ReadToEnd();
            }
            catch (Exception)
            {
                return null;
            }
        }

        protected void RunTest(string code)
        {
            try
            {
                var script = Script.Compile(CodeGenerator, Context, code);
                script.Run();
            }
            catch (SyntaxError ex)
            {
                var message = ex.Message;
                if (message.StartsWith("Line "))
                {
                    throw new SyntaxError(message.Substring(message.IndexOf(':') + 1).Trim());
                }
                throw;
            }
            catch (ReferenceError ex)
            {
                var message = ex.Message;
                if (message.StartsWith("Line "))
                {
                    throw new ReferenceError(message.Substring(message.IndexOf(':') + 1).Trim());
                }
                throw;
            }
        }
    }
}