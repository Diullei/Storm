using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Storm.Test.CsCode
{
    [TestClass]
    public class VarDeclarationWithIntInitTest : BaseTest
    {
        protected string Code = "var x = 100;";
        protected string Result =
              "using System;"
            + "using Storm;"
            + "public class C0 : JsObject"
            + "{"
                + "public C0(IDebugger debugger):base(debugger){}"

                + "private object x{get;set;}"

                + "public override object Exec()"
                + "{"
                    + "x = 100;"
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