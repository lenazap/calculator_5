using calculator_5.OneArgument;
using NUnit.Framework;

namespace calculator_5.Tests.OneArgument
{
    [TestFixture]
    public class SqrTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 4)]
        [TestCase(-3, 9)]
        public void SimpleTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Sqr();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}