using System;

namespace calculator_5.OneArgument
{
    public static class OneArgumentFactory
    {
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
                 default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}