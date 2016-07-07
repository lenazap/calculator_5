using System;

namespace calculator_5.OneArgument
{
    public class Sqrt: IOneArgumentCalculator
    {
        /// <summary>
        /// This is exctracting root of one argument
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Sqrt(firstArgument);
        }
    }
}