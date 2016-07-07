using calculator_5.OneArgument;
using NUnit.Framework;

namespace calculator_5.Tests.OneArgument
{
    [TestFixture]
    public class ExponentTests
    {
        [TestCase(1, 2.718)]
        [TestCase(0, 1)]
        [TestCase(2, 7.389)]
        public void SimpleTest(double first,double expected)
        {
            IOneArgumentCalculator calculator = new Exponent();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}