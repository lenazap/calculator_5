using calculator_5.OneArgument;
using NUnit.Framework;

namespace calculator_5.Tests.OneArgument
{
    [TestFixture]
    public class AbsTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(-3, 3)]
        public void SimpleTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Abs();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}