using calculator_5.OneArgument;
using NUnit.Framework;

namespace calculator_5.Tests.OneArgument
{
    [TestFixture]
    public class PercentTests
    {
        [TestCase(2, 0.02)]
        [TestCase(1, 0.01)]
        [TestCase(0, 0)]

        public void SimpleTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Percent();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);

        }
    }


}