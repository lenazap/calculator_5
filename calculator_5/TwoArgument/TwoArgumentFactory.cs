using System;

namespace calculator_5.TwoArgument
{
    public static class TwoArgumentFactory
    {
        /// <summary>
        /// This is factory for working with calculator of two argument
        /// </summary>
        /// <param name="calculatorName"></param>
        /// <returns></returns>
        public static ITwoArgumentCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "button_plus":
                    return new Plus();
                case "button_division":
                    return new Division();
                case "button_multiplication":
                    return new Multiplication();
                case "button_substraction":
                    return new Substraction();
                case "button_log":
                    return new Logarifm2();
                case "button_pow":
                    return new Pow();
                   
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}