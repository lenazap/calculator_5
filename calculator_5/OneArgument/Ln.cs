using System;

namespace calculator_5.OneArgument
{
    public class Ln: IOneArgumentCalculator
    {
        /// <summary>
        /// This is natural logarifm
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument <= 0)
            {
                throw new Exception("Неправильное значение аргумента");
            }
            return Math.Log(firstArgument, 2.7);
        }
    }
}