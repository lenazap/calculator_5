namespace calculator_5.OneArgument
{
    public class Sqr: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return firstArgument*firstArgument;
        }
    }
}