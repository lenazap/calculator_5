using calculator_5.OneArgument;
using NUnit.Framework;

namespace calculator_5.Tests.OneArgument
{
    [TestFixture]
    public class ArccosTests
    {
        [TestCase(0, 1.570)]
        [TestCase(1,0)]


        public void SimpleTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Arccos();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);

        }
    }


}