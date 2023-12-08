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
    /// MathAreaTrapezoid class represents a partial implementation of IFormula for calculating the area of a trapezoid.
    /// </summary>
    public partial class MathAreaTrapezoid : IFormula
    {
        // Private fields to store the values of breadth (b), height (h), top width (w), and area (A)
        private double b;
        private double h;
        private double w;
        private double A;

        // Constructor to initialize the values of breadth (b), height (h), top width (w), and area (A)
        public MathAreaTrapezoid(double b, double h, double w, double A)
        {
            this.b = b;
            this.h = h;
            this.w = w;
            this.A = A;
        }

        // Implementation of the Calculate method from the IFormula interface
        public double Calculate()
        {
            // Output the values of breadth, height, and top width to the console
            Console.WriteLine($"Breadth: {b}, Height: {h}, Top Width: {w}");

            // Calculate the result using the formula A = ((b + w) / 2) * h
            double result = ((b + w) / 2 * h);

            // Output the result to the console
            Console.WriteLine($"Result: {result}");

            // Return the calculated result
            return result;
        }

        // Implementation of the CalculateTerm2 method from the IFormula interface
        public double CalculateTerm2()
        {
            // Output the values of area, height, and top width to the console
            Console.WriteLine($"Area: {A}, Height: {h}, Top Width: {w}");

            // Calculate the result using the formula b = (2 * A) / (h + w)
            double result = (2 * A) / (h + w);

            // Output the result to the console
            Console.WriteLine($"Result: {result}");

            // Return the calculated result
            return result;
        }

        // Implementation of the CalculateTerm3 method from the IFormula interface
        public double CalculateTerm3()
        {
            // Output the values of area, breadth, and top width to the console
            Console.WriteLine($"Area: {A}, Breadth: {b}, Top Width: {w}");

            // Calculate the result using the formula h = (2 * A) / (b + w)
            double result = (2 * A) / (b + w);

            // Output the result to the console
            Console.WriteLine($"Result: {result}");

            // Return the calculated result
            return result;
        }

        // Implementation of the CalculateTerm4 method from the IFormula interface
        public double CalculateTerm4()
        {
            // Output the values of area, breadth, and height to the console
            Console.WriteLine($"Area: {A}, Breadth: {b}, Height: {h}");

            // Calculate the result using the formula w = ((-b * h) + (2 * A)) / h
            double result = ((-b * h) + (2 * A)) / h;

            // Output the result to the console
            Console.WriteLine($"Result: {result}");

            // Return the calculated result
            return result;
        }

        // Implementation of the GetFormula method from the IFormula interface
        public string GetFormula()
        {
            // Return the string representation of the formula
            return "A = ((b + a) * h) / 2";
        }

        // Implementation of the GetFormulaTerm2 method from the IFormula interface
        public string GetFormulaTerm2()
        {
            // Return the string representation of the formula for Term2
            return "b = (2 * A) / (h + a)";
        }

        // Implementation of the GetFormulaTerm3 method from the IFormula interface
        public string GetFormulaTerm3()
        {
            // Return the string representation of the formula for Term3
            return "h = (2 * A) / (b + a)";
        }

        // Implementation of the GetFormulaTerm4 method from the IFormula interface
        public string GetFormulaTerm4()
        {
            // Return the string representation of the formula for Term4
            return "a = (2 * A) / (b + h)";
        }
    }
}
