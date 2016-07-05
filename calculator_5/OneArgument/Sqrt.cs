using System;

namespace calculator_5.OneArgument
{
    public class Sqrt: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sqrt(firstArgument);
        }
    }
}