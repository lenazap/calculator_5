    using System;
    using calculator_5.TwoArgument;
    using NUnit.Framework;
    namespace calculator_5.Tests.TwoArgument
    {
        [TestFixture]
        public class TwoArgumentFactoryTest
        {
            [TestCase("button_plus",typeof(Plus))]
            [TestCase("button_substraction", typeof(Substraction))]
            [TestCase("button_multiplication", typeof(Multiplication))]
            [TestCase("button_division", typeof(Division))]
            [TestCase("button_pow", typeof(Pow))]
            [TestCase("button_log", typeof(Logarifm2))]
            public void CalculateTest(string name,Type type)
            {
                var calculator = TwoArgumentFactory.CreateCalculator(name);
                Assert.IsInstanceOf(type,calculator);
            }
        }
    }
