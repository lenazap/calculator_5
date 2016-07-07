using System;

namespace calculator_5.OneArgument
{
    public class Exponent: IOneArgumentCalculator
    {
        /// <summary>
        /// This is raising to power with exponent
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Exp(firstArgument);
        }
    }
}