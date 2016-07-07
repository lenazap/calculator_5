using System;

namespace calculator_5.TwoArgument
{
    public class Division: ITwoArgumentCalculator
    {
        /// <summary>
        /// This is division two argument, no more
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
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