using calculator_5.TwoArgument;
using NUnit.Framework;
namespace calculator_5.Tests.TwoArgument
{
     [TestFixture]
    public class SubstractionTests
    {
        [TestCase(60, 32, 28)]
        [TestCase(45, 9, 36)]
        [TestCase(40, 9, 31)]
        public void SimpleTest2(double first, double second, double expected)
        {
            ITwoArgumentCalculator calculator= new Substraction();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected,result);
        }
    }
}