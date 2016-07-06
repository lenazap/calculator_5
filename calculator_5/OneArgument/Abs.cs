using System;

namespace calculator_5.OneArgument
{
    public class Abs: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);
        }
    }
}