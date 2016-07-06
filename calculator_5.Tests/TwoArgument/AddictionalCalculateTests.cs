using calculator_5.TwoArgument;
using NUnit.Framework;

namespace calculator_5.Tests.TwoArgument
{
    [TestFixture]
    public class PlusTests
    {
        [TestCase(12,43,55)]
        [TestCase(45, 9, 54)]
        [TestCase(40, 9, 49)]


        public void SimpleTest(double first, double second, double expected)
        {
            ITwoArgumentCalculator calculator= new Plus();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected,result);

        }
    }

      
}