using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Storm.Test.CsCode
{
    [TestClass]
    public class VarDeclarationWithStrInitTest : BaseTest
    {
        protected string Code = "var x = 'string';";
        protected string Result =
              "using System;"
            + "using Storm;"
            + "public class C0 : JsObject"
            + "{"
                + "private System.Func<System.String,System.Object> eval;"

                + "private System.Func<System.Object,System.Boolean> isNaN;"

                + "public C0(System.Func<System.String,System.Object> eval, System.Func<System.Object,System.Boolean> isNaN, IDebugger debugger):base(debugger){this.eval = eval;this.isNaN = isNaN;}"

                + "private object x{get;set;}"

                + "public override object Exec()"
                + "{"
                    + "((dynamic)this).x = @\"string\";"
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