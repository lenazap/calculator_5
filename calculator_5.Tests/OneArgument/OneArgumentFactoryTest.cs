

using System;
using calculator_5.OneArgument;

using NUnit.Framework;
namespace calculator_5.Tests.OneArgument
{
    [TestFixture]

    public class OneArgumentFactoryTest
    {
        [TestCase("button_exp", typeof(Exponent))]
        [TestCase("button_ln", typeof(Ln))]
        [TestCase("button_abs", typeof(Abs))]
        [TestCase("button_cos", typeof(Cosinus))]
        [TestCase("button_sin", typeof(Sinus))]
        [TestCase("button_percent", typeof(Percent))]
        [TestCase("button_arccos", typeof(Arccos))]
        [TestCase("button_arcsin", typeof(Arcsin))]
        [TestCase("button_tg", typeof(Tangens))]
        [TestCase("button_x2", typeof(Sqr))]
        [TestCase("button_sqrt", typeof(Sqrt))]
        [TestCase("button_inv", typeof(Inversion))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
