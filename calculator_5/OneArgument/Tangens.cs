using System;

namespace calculator_5.OneArgument
{
    public class Tangens: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);
        }
    }
}