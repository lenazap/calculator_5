
using System;
using calculator_5.TwoArgument;
using NUnit.Framework;
namespace calculator_5.Tests.TwoArgument
{
    [TestFixture]

    public class DivisionTests
    {
        [TestCase(45, 9, 5)]
        [TestCase(150, 5, 30)]
        [TestCase(42, 7, 6)]
        public void SimpleTest2(double first, double second, double expected)
        {
            ITwoArgumentCalculator calculator = new Division();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void DivisionByZero()
        {
            ITwoArgumentCalculator calculator = new Division();
            Assert.Throws<Exception>(() => calculator.Calculate(5, 0));
        }
    }
}