using System;

namespace calculator_5.TwoArgument
{
    public class Logarifm2: ITwoArgumentCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Log(firstArgument, secondArgument);
        }
    }
}