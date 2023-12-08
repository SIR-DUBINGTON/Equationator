using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equationator
{
    /// <summary>
    /// PhysicsFormulaKineticEnergy represents a class for calculating kinetic energy using various formulas.
    /// </summary>
    public partial class PhysicsFormulaKineticEnergy : IFormula
    {
        // Private fields to store kinetic energy, mass, and velocity
        private double ke;
        private double m;
        private double v;

        // Constructor for PhysicsFormulaKineticEnergy
        public PhysicsFormulaKineticEnergy(double ke, double v, double m)
        {
            // Initialize the private fields with provided values
            this.ke = ke;
            this.m = m;
            this.v = v;
        }

        // Method to calculate kinetic energy
        public double Calculate()
        {
            // Output the values of mass and velocity
            Console.WriteLine($"Mass: {m}, Velocity: {v}");

            // Calculate kinetic energy using the formula KE = (m * v^2) / 2
            double ke = m * Math.Pow(v, 2) / 2;

            // Output the result and return it
            Console.WriteLine($"Result: {ke}");
            return ke;
        }

        // Method to calculate mass based on kinetic energy and velocity
        public double CalculateTerm2()
        {
            // Output the values of kinetic energy and velocity
            Console.WriteLine($"Kinetic Energy: {ke}, Velocity: {v}");

            // Calculate mass using the formula m = (2 * KE) / (v^2)
            double m = (2 * ke) / (Math.Pow(v, 2));

            // Output the result and return it
            Console.WriteLine($"Result: {m}");
            return m;
        }

        // Method to calculate velocity based on kinetic energy and mass
        public double CalculateTerm3()
        {
            // Output the values of kinetic energy and mass
            Console.WriteLine($"Kinetic Energy: {ke}, Mass: {m}");

            // Calculate velocity using the formula v = sqrt((2 * KE) / m)
            double v = Math.Sqrt((ke) / (m * 0.5));

            // Output the result and return it
            Console.WriteLine($"Result: {v}");
            return v;
        }

        // Placeholder method for additional term calculations
        public double CalculateTerm4()
        {
            return 0;
        }

        // Method to get the formula for kinetic energy
        public string GetFormula()
        {
            return "KE = (m * v^2) / 2";
        }

        // Method to get the formula for mass based on kinetic energy and velocity
        public string GetFormulaTerm2()
        {
            return "m = (2 * KE) / (v^2)";
        }

        // Method to get the formula for velocity based on kinetic energy and mass
        public string GetFormulaTerm3()
        {
            return "v = sqrt((2 * KE) / m)";
        }
    }
}
