using System;

namespace Equationator
{
    /// <summary>
    /// PhysicsFormulaVelocity represents a class for calculating velocity using various formulas.
    /// </summary>
    public partial class PhysicsFormulaVelocity : IFormula
    {
        // Private fields to store velocity, initial velocity, time, and acceleration
        private double v;
        private double u;
        private double t;
        private double a;

        // Constructor for PhysicsFormulaVelocity
        public PhysicsFormulaVelocity(double u, double a, double t, double v)
        {
            // Initialize the private fields with provided values
            this.v = v;
            this.u = u;
            this.t = t;
            this.a = a;
        }

        // Method to calculate velocity
        public double Calculate()
        {
            // Output the values of initial velocity, acceleration, and time
            Console.WriteLine($"Initial Velocity: {u}, Acceleration: {a}, Time: {t}");

            // Calculate velocity using the formula v = u + (a * t)
            double v = u + (a * t);

            // Output the result and return it
            Console.WriteLine($"Result: {v}");
            return v;
        }

        // Method to calculate initial velocity based on velocity, acceleration, and time
        public double CalculateTerm2()
        {
            // Output the values of velocity, acceleration, and time
            Console.WriteLine($"Velocity: {v}, Acceleration: {a}, Time: {t}");

            // Calculate initial velocity using the formula u = -(a * t) + v
            double u = -(a * t) + v;

            // Output the result and return it
            Console.WriteLine($"Result: {u}");
            return u;
        }

        // Method to calculate acceleration based on velocity, initial velocity, and time
        public double CalculateTerm3()
        {
            // Output the values of velocity, initial velocity, and time
            Console.WriteLine($"Velocity: {v}, Initial Velocity: {u}, Time: {t}");

            // Calculate acceleration using the formula a = -(u + v) / t
            double a = (-u + v) / t;

            // Output the result and return it
            Console.WriteLine($"Result: {a}");
            return a;
        }

        // Method to calculate time based on velocity, initial velocity, and acceleration
        public double CalculateTerm4()
        {
            // Output the values of velocity, initial velocity, and acceleration
            Console.WriteLine($"Velocity: {v}, Initial Velocity: {u}, Acceleration: {a}");

            // Calculate time using the formula t = -(u + v) / a
            double t = -(u + v) / a;

            // Output the result and return it
            Console.WriteLine($"Result: {t}");
            return t;
        }

        // Method to get the formula for velocity
        public string GetFormula()
        {
            return "v = u + a * t";
        }

        // Method to get the formula for initial velocity based on velocity, acceleration, and time
        public string GetFormulaTerm2()
        {
            return "u = -(a * t) + v";
        }

        // Method to get the formula for acceleration based on velocity, initial velocity, and time
        public string GetFormulaTerm3()
        {
            return "a = -(u + v) / t";
        }

        // Method to get the formula for time based on velocity, initial velocity, and acceleration
        public string GetFormulaTerm4()
        {
            return "t = -(u + v) / a";
        }
    }
}
