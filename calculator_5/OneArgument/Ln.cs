using System;

namespace calculator_5.OneArgument
{
    public class Ln: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument <= 0)
            {
                throw new Exception("\n Неправильное значение аргумента");
            }
            return Math.Log(firstArgument, 2.7);
        }
    }
}