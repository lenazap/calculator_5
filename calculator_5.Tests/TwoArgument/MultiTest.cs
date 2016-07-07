using calculator_5.TwoArgument;
using NUnit.Framework;
namespace calculator_5.Tests.TwoArgument
{
     [TestFixture]
    public class MultiplicationTests
    {
        [TestCase(5, 32, 160)]
        [TestCase(12, 3, 36)]
        [TestCase(10, 10, 100)]
        public void SimpleTest2(double first, double second, double expected)
        {
            ITwoArgumentCalculator calculator= new Multiplication();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected,result);
        }
    }
}