using System;

namespace calculator_5.TwoArgument
{
    public class Logarifm2: ITwoArgumentCalculator
    {
        /// <summary>
        /// This is logarifm, first argument - number, second argument - base of logarifm
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Log(firstArgument, secondArgument);
        }
    }
}