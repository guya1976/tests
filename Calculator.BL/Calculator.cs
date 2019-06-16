namespace Calculator.BL
{
    using System;

    public class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            checked
            {
                return a + b;
            }
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}