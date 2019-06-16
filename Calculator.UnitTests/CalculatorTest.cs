namespace Calculator.UnitTests
{
    using System;
    using BL;
    using NUnit.Framework;

    [TestFixture]
    public class CalculatorTest
    {
        private ICalculator _calculator;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _calculator = new BL.Calculator();
        }

        [TestCase(1, 2, ExpectedResult = 3)]
        [TestCase(10, 20, ExpectedResult = 30)]
        public int Add_WithTwoNumbers_ShouldAddCorrectly(int a, int b)
        {
            return _calculator.Add(a, b);
        }

        [Test]
        public void Add_WithTooLargeInput_ShouldThrowOverflowException()
        {
            Assert.Throws<OverflowException>(() => _calculator.Add(int.MaxValue, 1));
        }
    }
}