namespace calculator_5.OneArgument
{
    public class Percent : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return firstArgument / 100;
        }
    }
}