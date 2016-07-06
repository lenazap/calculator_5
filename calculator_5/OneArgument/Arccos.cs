using System;

namespace calculator_5.OneArgument
{
    public class Arccos: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Acos(firstArgument);
        }
    }
}