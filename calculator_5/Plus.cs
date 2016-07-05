namespace calculator_5
{
    public class Plus: ITwoArgumentCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}