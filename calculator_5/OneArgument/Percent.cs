namespace calculator_5.OneArgument
{
    public class Percent : IOneArgumentCalculator
    {
        /// <summary>
        /// This is percent of value
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return firstArgument / 100;
        }
    }
}