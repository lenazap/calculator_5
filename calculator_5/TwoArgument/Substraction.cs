namespace calculator_5.TwoArgument
{
    public class Substraction: ITwoArgumentCalculator
    {
        /// <summary>
        /// This is substraction two argument, no more
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}