using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Storm.Test.CsCode
{
    [TestClass]
    public class BinaryExpressionTest : BaseTest
    {
        protected string Code = "var x = 100; x = 3 + 5";
        protected string Result =
              "using System;"
            + "using Storm;"
            + "public class C0 : JsObject"
            + "{"
                + "private System.Func<System.String,System.Object> eval;"
            + "public C0(System.Func<System.String,System.Object> eval, IDebugger debugger):base(debugger){this.eval = eval;}"

            + "private object x{get;set;}"

            + "public override object Exec()"
            + "{"
            + "((dynamic)this).x = 100;"
            + "return ((dynamic)this).x = (3 + 5);"
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