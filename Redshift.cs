using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equationator
{
    /// <summary>
    /// Redshift is a class that represents a formula for calculating redshift in astronomy.
    /// </summary>
    public partial class Redshift : IFormula
    {
        private double z;  // Redshift value
        private double c = 299792458;  // Speed of light in meters per second
        private double v;  // Velocity value

        /// <summary>
        /// Constructor for the Redshift class.
        /// </summary>
        /// <param name="z">Initial redshift value.</param>
        /// <param name="v">Velocity value.</param>
        public Redshift(double z, double v)
        {
            this.z = z;
            this.v = v;
        }

        /// <summary>
        /// Calculates the redshift using the formula z = v / c.
        /// </summary>
        /// <returns>The calculated redshift value.</returns>
        public double Calculate()
        {
            Console.WriteLine($"Redshift: {v}, {c}");
            double z = v / c;
            Console.WriteLine($"Result: {z}");
            return z;
        }

        /// <summary>
        /// Calculates the velocity using the formula v = z * c.
        /// </summary>
        /// <returns>The calculated velocity value.</returns>
        public double CalculateTerm2()
        {
            Console.WriteLine($"z: {z}, {c}");
            double v = z * c;
            Console.WriteLine($"Result: {v}");
            return v;
        }

        /// <summary>
        /// Placeholder for additional calculation terms (not implemented).
        /// </summary>
        /// <returns>Zero as a placeholder.</returns>
        public double CalculateTerm3()
        {
            return 0;
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
        /// Returns the formula for redshift.
        /// </summary>
        /// <returns>The formula string.</returns>
        public string GetFormula()
        {
            return "z = (lambda observed - lambda emitted) / lambda emitted";
        }
    }
}
