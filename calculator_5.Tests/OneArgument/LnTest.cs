using System;
using calculator_5.OneArgument;
using NUnit.Framework;

namespace calculator_5.Tests.OneArgument
{
    [TestFixture]
    public class LnTests
    {
        [TestCase(4, 1.395)]
        [TestCase(8, 2.093)]
        public void SimpleTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Ln();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }

        [Test]
        public void LnWithZero(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Ln();
            Assert.Throws<Exception>(() => calculator.Calculate(-1));
        }
    }
}