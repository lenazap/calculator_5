using calculator_5.OneArgument;
using NUnit.Framework;

namespace calculator_5.Tests.OneArgument
{
    [TestFixture]
    public class TgTests
    {
        [TestCase(2, -2.185)]
        [TestCase(1, 1.557)]
        [TestCase(0, 0)]

        public void SimpleTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Tangens();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);

        }
    }


}