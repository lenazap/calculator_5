using System;

namespace calculator_5.OneArgument
{
    public class Arcsin: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Asin(firstArgument);
        }
    }
}