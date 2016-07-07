namespace calculator_5.OneArgument
{
    public class Inversion: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return -firstArgument;
        }
    }
}