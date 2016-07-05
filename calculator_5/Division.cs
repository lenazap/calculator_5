namespace calculator_5
{
    public class Division: ITwoArgumentCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument/secondArgument;
        }
    }
}