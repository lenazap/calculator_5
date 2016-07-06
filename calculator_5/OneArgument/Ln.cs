using System;

namespace calculator_5.OneArgument
{
    public class Ln: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument, 2.7);
        }
    }
}