using System;

namespace calculator_5.OneArgument
{
    public class Cosinus: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}