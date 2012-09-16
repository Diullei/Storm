using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Storm.Test.CsCode
{
    [TestClass]
    public class BaseTest
    {
        protected Context Context { get; set; }
        protected Code CodeGenerator { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            Context = new Context(new Scope());
            CodeGenerator = new Code();
        }

        protected object Run(string source)
        {
            var script = Script.Compile(CodeGenerator, Context, source);
            return script.Run();
        }

        protected void RunPerformance(string source)
        {
            try
            {
                var script = Script.Compile(CodeGenerator, Context, source);

                const int rate = 10000000;
                var ini = DateTime.Now;
                for (var i = 0; i < rate; i++)
                {
                    script.Run();
                }

                var end = rate / ((DateTime.Now - ini).Milliseconds) / 1000;
            }
            catch (DivideByZeroException)
            {
            }
        }

        protected object RunWithDebugEnabled(string source)
        {
            var debugger = new Debugger {Source = source};
            var script = Script.Compile(CodeGenerator, Context, source, debugger);
            return script.Run();
        }
    }
}