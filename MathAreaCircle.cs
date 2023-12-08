// Import necessary namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace for the application
namespace Equationator
{
    /// <summary>
    /// MathAreaCircle class represents a partial implementation of IFormula for calculating the area of a circle.
    /// </summary>
    public partial class MathAreaCircle : IFormula
    {
        // Private fields to store the values of radius (r) and area (A)
        private double r;
        private double A;

        // Constructor to initialize the values of radius (r) and area (A)
        public MathAreaCircle(double r, double A)
        {
            this.r = r;
            this.A = A;
        }

        // Implementation of the Calculate method from the IFormula interface
        public double Calculate()
        {
            // Output the value of the radius to the console
            Console.WriteLine($"Radius: {r}");

            // Calculate the result using the formula A = πr²
            double result = (Math.PI * Math.Pow(r, 2));

            // Output the result to the console
            Console.WriteLine($"Result: {result}");

            // Return the calculated result
            return result;
        }

        // Implementation of the CalculateTerm2 method from the IFormula interface
        public double CalculateTerm2()
        {
            // Output the value of the area to the console
            Console.WriteLine($"Area: {A}");

            // Calculate the result using the formula r = sqrt(A / π)
            double result = Math.Sqrt(A / Math.PI);

            // Output the result to the console
            Console.WriteLine($"Result: {result}");

            // Return the calculated result
            return result;
        }

        // Implementation of the CalculateTerm3 method from the IFormula interface
        public double CalculateTerm3()
        {
            // Term3 calculation is not implemented, returns 0
            return 0;
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
            return "A = πr²";
        }
    }
}
