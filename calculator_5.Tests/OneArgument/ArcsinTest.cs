using calculator_5.OneArgument;
using NUnit.Framework;

namespace calculator_5.Tests.OneArgument
{
    [TestFixture]
    public class ArcsinTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1.570)]
        public void SimpleTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Arcsin();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}