using System;

namespace calculator_5.TwoArgument
{
    public class Division: ITwoArgumentCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Деление на 0");
            }
           return firstArgument/secondArgument;
        }
    }
}