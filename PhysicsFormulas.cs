using System;

namespace Equationator
{
    /// <summary>
    /// PhysicsFormulas represents a class for calculating force using various formulas.
    /// </summary>
    public partial class PhysicsFormulas : IFormula
    {
        // Private fields to store mass, gravity, and force
        private double m;
        private double g;
        private double f;

        // Constructor for PhysicsFormulas
        public PhysicsFormulas(double m, double g, double f)
        {
            // Initialize the private fields with provided values
            this.m = m;
            this.g = g;
            this.f = f;
        }

        // Method to calculate force
        public double Calculate()
        {
            // Output the values of mass and gravity
            Console.WriteLine($"Mass: {m}, Gravity: {g}");

            // Calculate force using the formula F = m * g
            double f = m * g;

            // Output the result and return it
            Console.WriteLine($"Result: {f}");
            return f;
        }

        // Method to calculate mass based on force and gravity
        public double CalculateTerm2()
        {
            // Output the values of force and gravity
            Console.WriteLine($"Force: {f}, Gravity: {g}");

            // Calculate mass using the formula m = F / g
            double m = f / g;

            // Output the result and return it
            Console.WriteLine($"Result: {m}");
            return m;
        }

        // Method to calculate gravity based on force and mass
        public double CalculateTerm3()
        {
            // Output the values of force and mass
            Console.WriteLine($"Force: {f}, Mass: {m}");

            // Calculate gravity using the formula g = F / m
            double g = f / m;

            // Output the result and return it
            Console.WriteLine($"Result: {g}");
            return g;
        }

        // Placeholder method for additional term calculations
        public double CalculateTerm4()
        {
            return 0;
        }

        // Method to get the formula for force
        public string GetFormula()
        {
            return "F = m * g";
        }

        // Method to get the formula for mass based on force and gravity
        public string GetFormulaTerm2()
        {
            return "m = F / g";
        }

        // Method to get the formula for gravity based on force and mass
        public string GetFormulaTerm3()
        {
            return "g = F / m";
        }
    }
}
