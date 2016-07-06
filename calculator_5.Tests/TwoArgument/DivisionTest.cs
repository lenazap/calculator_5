
using calculator_5.TwoArgument;
using NUnit.Framework;
namespace calculator_5.Tests.TwoArgument
{
    [TestFixture]

    public class DivisionTests
    {
        [TestCase(45, 9, 5)]
        public void SimpleTest2(double first, double second, double expected)
        {
            ITwoArgumentCalculator calculator = new Division();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}