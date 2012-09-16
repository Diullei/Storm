using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Storm.Test.CsCode
{
    [TestClass]
    public class VarDeclarationWithStrInitTest : BaseTest
    {
        protected string Code = "var x = 'string';";
        protected string Result =
              "using Storm;"
            + "public class C0 : JsObject"
            + "{"
                + "public C0(IDebugger debugger):base(debugger){}"

                + "private object private_x{get;set;}"

                + "public override object Exec()"
                + "{"
                    + "this.private_x = \"string\";"
                    + "return this.private_x;"
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