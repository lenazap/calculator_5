namespace calculator_5.OneArgument
{
    public class Sqr: IOneArgumentCalculator
    {
        /// <summary>
        /// This is multiplication two argument, no more
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return firstArgument*firstArgument;
        }
    }
}