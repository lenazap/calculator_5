using System;

namespace calculator_5.OneArgument
{
    public class Sinus: IOneArgumentCalculator
    {
        /// <summary>
        /// This is sinus of one argument
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}