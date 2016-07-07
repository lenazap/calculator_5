using System;

namespace calculator_5.OneArgument
{
    ///
    public class Logarifm: IOneArgumentCalculator
    {
        /// <summary>
        /// This is common logarifm of one argument
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Log10(firstArgument);
        }
    }
}