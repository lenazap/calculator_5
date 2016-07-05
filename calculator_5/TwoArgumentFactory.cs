using System;
using System.Windows.Forms;

namespace calculator_5
{
    public class TwoArgumentFactory
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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}