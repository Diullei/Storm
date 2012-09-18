using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Storm.Test.CsCode
{
    [TestClass]
    public class EvalTest : BaseTest
    {
        protected string Code = "var x = 3; var y = 33; eval('x = 1; var f = 321'); y = 9; inspectX(x); inspectY(y); inspectF(f)";

        public override void CustomInitialize()
        {
            Context.SetFunction<object>("inspectX", (val) => Assert.AreEqual(1, val));
            Context.SetFunction<object>("inspectY", (val) => Assert.AreEqual(9, val));
            Context.SetFunction<object>("inspectF", (val) => Assert.AreEqual(321, val));
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