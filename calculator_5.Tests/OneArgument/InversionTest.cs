using calculator_5.OneArgument;
using NUnit.Framework;

namespace calculator_5.Tests.OneArgument
{
    [TestFixture]
    public class InversionTests
    {
        [TestCase(2, -2)]
        [TestCase(-1, 1)]
        [TestCase(0, 0)]
        public void SimpleTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Inversion();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}