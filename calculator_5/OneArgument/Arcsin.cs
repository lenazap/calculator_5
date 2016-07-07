using System;

namespace calculator_5.OneArgument
{
    public class Arcsin: IOneArgumentCalculator
    {
        /// <summary>
        /// This is arcson of one argument
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Asin(firstArgument);
        }
    }
}