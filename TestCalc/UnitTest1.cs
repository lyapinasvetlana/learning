using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vs.Calculator;

namespace Vs.TestCalc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum()
        {
            Assert.IsTrue(Calc.Sum(1,2)==3);
        }
    }
}
