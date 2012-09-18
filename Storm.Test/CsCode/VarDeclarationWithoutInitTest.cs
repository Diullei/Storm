using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Storm.Test.CsCode
{
    [TestClass]
    public class VarDeclarationWithoutInitTest : BaseTest
    {
        protected string Code = "var x;";
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
                    + "((dynamic)this).x = JsObject.Null;"
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
    }
}
