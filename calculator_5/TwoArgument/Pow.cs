using System;

namespace calculator_5.TwoArgument
{
    public class Pow: ITwoArgumentCalculator

{
        /// <summary>
        /// This is raising to a power, first argument - number, second argument - exponent
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
}
}