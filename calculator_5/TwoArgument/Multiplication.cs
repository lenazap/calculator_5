namespace calculator_5.TwoArgument
{
    public class Multiplication: ITwoArgumentCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument*secondArgument;
        }
    }
}