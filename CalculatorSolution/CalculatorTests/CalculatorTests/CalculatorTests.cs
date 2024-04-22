// CalculatorTests.cs
using System;
using Xunit;
using CalculatorSolution.Calculator;

namespace CalculatorSolution.CalculatorTests
{
    public class CalculatorTests
    {
        [Fact]
        public void TestAdd()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Add(3, 5);
            Assert.Equal(8, result);
        }

        [Fact]
        public void TestSubtract()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Subtract(8, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestMultiply()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Multiply(3, 4);
            Assert.Equal(12, result);
        }

        [Fact]
        public void TestDivide()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Divide(10, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestDivideByZero()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<ArgumentException>(() => calculator.Divide(10, 0));
        }

        [Fact]
        public void TestHistory()
        {
            History history = new History();
            history.AddOperation("3 + 5");
            history.AddOperation("8 - 3");
            history.AddOperation("3 * 4");

            var operations = history.GetOperations();
            Assert.Equal(3, operations.Count);
            Assert.Equal("3 + 5", operations[0]);
            Assert.Equal("8 - 3", operations[1]);
            Assert.Equal("3 * 4", operations[2]);
        }
    }
}
