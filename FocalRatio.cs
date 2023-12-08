using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equationator
{
    // Define a partial class named FocalRatio that implements the IFormula interface
    public partial class FocalRatio : IFormula
    {
        // Private fields to store the values of f, D, and N
        private double f;
        private double D;
        private double N;

        // Constructor to initialize the values of f, D, and N
        public FocalRatio(double f, double D, double N)
        {
            this.f = f;
            this.D = D;
            this.N = N;
        }

        // Implementation of the Calculate method from the IFormula interface
        public double Calculate()
        {
            // Output the values of f and D to the console
            Console.WriteLine($"Focal Ratio: {f}, {D}");

            // Calculate the result using the formula N = f / D
            double result = f / D;

            // Output the result to the console
            Console.WriteLine($"Result: {result}");

            // Return the calculated result
            return result;
        }

        // Implementation of the CalculateTerm2 method from the IFormula interface
        public double CalculateTerm2()
        {
            // Output the values of N and D to the console
            Console.WriteLine($"f: {N}, {D}");

            // Calculate the result using the formula f = N * D
            double result = N * D;

            // Output the result to the console
            Console.WriteLine($"Result: {result}");

            // Return the calculated result
            return result;
        }

        // Implementation of the CalculateTerm3 method from the IFormula interface
        public double CalculateTerm3()
        {
            // Output the values of f and N to the console
            Console.WriteLine($"D: {f}, {N}");

            // Calculate the result using the formula D = f / N
            double result = f / N;

            // Output the result to the console
            Console.WriteLine($"Result: {result}");

            // Return the calculated result
            return result;
        }

        // Implementation of the CalculateTerm4 method from the IFormula interface
        public double CalculateTerm4()
        {
            // Term4 calculation is not implemented, returns 0
            return 0;
        }

        // Implementation of the GetFormula method from the IFormula interface
        public string GetFormula()
        {
            // Return the string representation of the formula
            return "N = f / D";
        }
    }
}
