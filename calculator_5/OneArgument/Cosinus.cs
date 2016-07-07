using System;

namespace calculator_5.OneArgument
{
    public class Cosinus: IOneArgumentCalculator
    {
        /// <summary>
        /// This is cosinus of one argument
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}