using System;

namespace calculator_5.OneArgument
{
    public class Tangens: IOneArgumentCalculator
    {
        /// <summary>
        /// This is tangens of one argument
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);
        }
    }
}