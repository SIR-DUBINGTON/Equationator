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
    /// MathAreaRectangle class represents a partial implementation of IFormula for calculating the area of a rectangle.
    /// </summary>
    public partial class MathAreaRectangle : IFormula
    {
        // Private fields to store the values of breadth (b), height (h), and area (a)
        private double b;
        private double h;
        private double a;

        // Constructor to initialize the values of breadth (b), height (h), and area (a)
        public MathAreaRectangle(double b, double h, double a)
        {
            this.b = b;
            this.h = h;
            this.a = a;
        }

        // Implementation of the Calculate method from the IFormula interface
        public double Calculate()
        {
            // Output the values of breadth and height to the console
            Console.WriteLine($"Breadth: {b}, Height: {h}");

            // Calculate the result using the formula a = b * h
            double result = b * h;

            // Output the result to the console
            Console.WriteLine($"Result: {result}");

            // Return the calculated result
            return result;
        }

        // Implementation of the CalculateTerm2 method from the IFormula interface
        public double CalculateTerm2()
        {
            // Output the values of area and height to the console
            Console.WriteLine($"Area: {a}, Height: {h}");

            // Calculate the result using the formula b = a / h
            double result = a / h;

            // Output the result to the console
            Console.WriteLine($"Result: {result}");

            // Return the calculated result
            return result;
        }

        // Implementation of the CalculateTerm3 method from the IFormula interface
        public double CalculateTerm3()
        {
            // Output the values of area and breadth to the console
            Console.WriteLine($"Area: {a}, Breadth: {b}");

            // Calculate the result using the formula h = a / b
            double result = a / b;

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
            return "a = b * h";
        }

        // Implementation of the GetFormulaTerm2 method from the IFormula interface
        public string GetFormulaTerm2()
        {
            // Return the string representation of the formula for Term2
            return "b = a / h";
        }

        // Implementation of the GetFormulaTerm3 method from the IFormula interface
        public string GetFormulaTerm3()
        {
            // Return the string representation of the formula for Term3
            return "h = a / b";
        }
    }
}
