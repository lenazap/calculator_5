using System;

namespace calculator_5.OneArgument
{
    public class Logarifm: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log10(firstArgument);
        }
    }
}