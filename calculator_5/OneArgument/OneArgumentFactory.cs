using System;

namespace calculator_5.OneArgument
{
    public static class OneArgumentFactory
    {
        /// <summary>
        /// This is factory for working with calculator of one argument
        /// </summary>
        /// <param name="calculatorName"></param>
        /// <returns></returns>
        public static IOneArgumentCalculator CreateCalculator(string calculatorName)
        {
            switch(calculatorName)
            {
                case "button_sin":
                    return new Sinus();
                case "button_cos":
                    return new Cosinus();
                case "button_sqrt":
                    return new Sqrt();
                case "button_exp":
                    return new Exponent();
                case "button_log":
                    return new Logarifm();
                case "button_x2":
                    return new Sqr();
                case "button_tg":
                    return new Tangens();
                case "button_inv":
                    return new Inversion();
                case "button_abs":
                    return new Abs();
                case "button_arcsin":
                    return new Arcsin();
                case "button_arccos":
                    return new Arccos();
                case "button_ln":
                    return new Ln();
                case "button_percent":
                    return new Percent();
                 default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}