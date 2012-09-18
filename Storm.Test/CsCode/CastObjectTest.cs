using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Storm.Test.CsCode
{
    [TestClass]
    public class CastObjectTest : BaseTest
    {
        protected string Code = "var x = 3; inspect(x * 3); concat1('str' + 'ing'); concat2('str' + 'ing' + 2)";

        public override void CustomInitialize()
        {
            Context.SetFunction<object>("inspect", (val) => Assert.AreEqual(9, val));
            Context.SetFunction<object>("concat1", (val) => Assert.AreEqual("string", val));
            Context.SetFunction<object>("concat2", (val) => Assert.AreEqual("string2", val));
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