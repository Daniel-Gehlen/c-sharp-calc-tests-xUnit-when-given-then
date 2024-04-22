// Calculator/History.cs
using System.Collections.Generic;

namespace CalculatorSolution.Calculator
{
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
