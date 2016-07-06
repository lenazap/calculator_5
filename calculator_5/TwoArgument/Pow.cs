using System;

namespace calculator_5.TwoArgument
{
    public class Pow: ITwoArgumentCalculator

{
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
}
}