// Calculator.cs
using System;
using System.Collections.Generic;

namespace CalculatorSolution.Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("Cannot divide by zero");

            return a / b;
        }
    }

    public class History
    {
        private List<string> operations = new List<string>();

        public void AddOperation(string operation)
        {
            operations.Add(operation);
        }

        public List<string> GetOperations()
        {
            return operations;
        }
    }
}
