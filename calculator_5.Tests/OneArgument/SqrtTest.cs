using calculator_5.OneArgument;
using NUnit.Framework;

namespace calculator_5.Tests.OneArgument
{
    [TestFixture]
    public class SqrtTests
    {
        [TestCase(1, 1)]
        [TestCase(16, 4)]
        [TestCase(9, 3)]
        public void SimpleTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Sqrt();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}