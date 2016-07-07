namespace calculator_5.TwoArgument
{
    public class Plus: ITwoArgumentCalculator
    {
        /// <summary>
        /// This is addiction two argument, no more
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}