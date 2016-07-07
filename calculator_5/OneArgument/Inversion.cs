namespace calculator_5.OneArgument
{
    public class Inversion: IOneArgumentCalculator
    {
        /// <summary>
        /// This is infersion of value
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return -firstArgument;
        }
    }
}