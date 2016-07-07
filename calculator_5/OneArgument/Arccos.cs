using System;

namespace calculator_5.OneArgument
{
    public class Arccos: IOneArgumentCalculator
    {
        /// <summary>
        /// This is arccos of one argument
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Acos(firstArgument);
        }
    }
}