using System;

namespace calculator_5.OneArgument
{
    public class Exponent: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Exp(firstArgument);
        }
    }
}