using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equationator
{
    /// <summary>
    /// SchwarszchildRadius is a class that represents a formula for calculating the Schwarzschild radius.
    /// </summary>
    public partial class SchwarszchildRadius : IFormula
    {
        private double r;  // Schwarzschild radius
        private double G;  // Gravitational constant
        private double M;  // Mass
        private double c = 299792458;  // Speed of light in meters per second

        /// <summary>
        /// Constructor for the SchwarszchildRadius class.
        /// </summary>
        /// <param name="r">Initial Schwarzschild radius value.</param>
        /// <param name="G">Gravitational constant value.</param>
        /// <param name="M">Mass value.</param>
        public SchwarszchildRadius(double r, double G, double M)
        {
            this.r = r;
            this.G = G;
            this.M = M;
        }

        /// <summary>
        /// Calculates the Schwarzschild radius using the formula r = (2GM) / c².
        /// </summary>
        /// <returns>The calculated Schwarzschild radius value.</returns>
        public double Calculate()
        {
            Console.WriteLine($"Radius: {G}, {M}, {c}");
            double r = ((2) * (G) * (M)) / (Math.Pow(c, 2));
            Console.WriteLine($"Result: {r}");
            return r;
        }

        /// <summary>
        /// Calculates the gravitational constant using the formula G = (r * c²) / (2M).
        /// </summary>
        /// <returns>The calculated gravitational constant value.</returns>
        public double CalculateTerm2()
        {
            Console.WriteLine($"G: {r}, {c}, {M}");
            double G = (r * Math.Pow(c, 2)) / ((M) * (2));
            Console.WriteLine($"Result: {G}");
            return G;
        }

        /// <summary>
        /// Calculates the mass using the formula M = (r * c²) / (2G).
        /// </summary>
        /// <returns>The calculated mass value.</returns>
        public double CalculateTerm3()
        {
            Console.WriteLine($"M: {r}, {c}, {G}");
            double M = (r * Math.Pow(c, 2)) / ((G) * (2));
            Console.WriteLine($"Result: {M}");
            return M;
        }

        /// <summary>
        /// Placeholder for additional calculation terms (not implemented).
        /// </summary>
        /// <returns>Zero as a placeholder.</returns>
        public double CalculateTerm4()
        {
            return 0;
        }

        /// <summary>
        /// Returns the formula for the Schwarzschild radius.
        /// </summary>
        /// <returns>The formula string.</returns>
        public string GetFormula()
        {
            return "r = (2GM) / c²";
        }
    }
}
