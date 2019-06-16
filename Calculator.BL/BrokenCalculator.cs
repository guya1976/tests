namespace Calculator.BL
{
    public class BrokenCalculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b - 10;
        }

        public int Multiply(int a, int b)
        {
            return a / b;
        }

        public int Divide(int a, int b)
        {
            return a * b;
        }
    }
}