using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Storm.Test.CsCode
{
    [TestClass]
    public class IfStatementTest : BaseTest
    {
        protected string Code = "var x = 100; var y = 3; var z = 0; if(x > y) z = 1234;";
        protected string Result =
            "using System;"
            + "using Storm;"
            + "public class C0 : JsObject"
            + "{"
                + "private System.Action<System.String> eval;"

                + "public C0(System.Action<System.String> eval, IDebugger debugger):base(debugger){this.eval = eval;}"

                + "private object x{get;set;}"

                + "private object y{get;set;}"

                + "private object z{get;set;}"

                + "public override object Exec()"
                + "{"
                    + "((dynamic)this).x = 100;"
                    + "((dynamic)this).y = 3;"
                    + "((dynamic)this).z = 0;"
                    + "if((((dynamic)this).x > ((dynamic)this).y))"
                    + "{"
                        + "((dynamic)this).z = 1234;"
                    + "}"
                    + "return JsObject.Undefined;"
                + "}"
            + "}";

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