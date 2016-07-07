using System;

namespace calculator_5.OneArgument
{
    public class Abs: IOneArgumentCalculator
    {
        /// <summary>
        /// This is module of value
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);
        }
    }
}