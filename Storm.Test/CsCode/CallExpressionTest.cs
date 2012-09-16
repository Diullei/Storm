using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Storm.Test.CsCode
{
    [TestClass]
    public class CallExpressionTest : BaseTest
    {
        protected string Code = "var x = 100; x = 3 + 5; print(); print2(x);";
        protected string Result =
              "using System;"
            + "using Storm;"
            + "public class C0 : JsObject"
            + "{"
                + "private System.Action print;"

                + "private System.Action<System.Object> print2;"

                + "public C0(System.Action print, System.Action<System.Object> print2, IDebugger debugger):base(debugger){this.print = print;this.print2 = print2;}"

                + "private object x{get;set;}"

                + "public override object Exec()"
                + "{"
                    + "x = 100;"
                    + "x = (3 + 5);"
                    + "print();"
                    + "print2(x);"
                    + "return JsObject.Undefined;"
                + "}"
            + "}";

        public override void CustomInitialize()
        {
            Context.SetFunction("print", new Action(Console.WriteLine));
            Context.SetFunction<object>("print2", Console.WriteLine);
        }

        [TestMethod]
        public void GenerateCsCodeTest()
        {
            Run(Code);
            Assert.AreEqual(Result, CodeGenerator.CsCode);
        }

        [TestMethod]
        public void RunTest()
        {
            Run(Code);
        }

        [TestMethod]
        public void RunPerformanceTest()
        {
            RunPerformance(Code);
        }

        [TestMethod]
        public void RunWithDebugEnabled()
        {
            RunWithDebugEnabled(Code);
        }
    }
}