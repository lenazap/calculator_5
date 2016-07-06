using System;

namespace calculator_5.TwoArgument
{
    public static class TwoArgumentFactory
    {
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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}