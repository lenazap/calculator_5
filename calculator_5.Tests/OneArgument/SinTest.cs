using calculator_5.OneArgument;
using calculator_5.TwoArgument;
using NUnit.Framework;

namespace calculator_5.Tests.OneArgument
{
    [TestFixture]
    public class SinTests
    {
        [TestCase(1, 0.841)]
        [TestCase(2, 0.909)]
        [TestCase(0, 0)]


        public void SimpleTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Sinus();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result,0.001);

        }
    }


}