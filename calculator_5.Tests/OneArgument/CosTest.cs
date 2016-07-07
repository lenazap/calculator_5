using calculator_5.OneArgument;
using NUnit.Framework;

namespace calculator_5.Tests.OneArgument
{
    [TestFixture]
    public class CosTests
    {
        [TestCase(1, 0.540)]
        [TestCase(0, 1)]
        [TestCase(0.5, 0.877)]
        public void SimpleTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Cosinus();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result,0.001);
        }
    }
}