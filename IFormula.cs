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
    /// IFormula interface defines the contract for formulas used in the Equationator application.
    /// </summary>
    public interface IFormula
    {
        /// <summary>
        /// Calculates the main result of the formula.
        /// </summary>
        /// <returns>The calculated result.</returns>
        double Calculate();

        /// <summary>
        /// Calculates the second term of the formula.
        /// </summary>
        /// <returns>The calculated result of the second term.</returns>
        double CalculateTerm2();

        /// <summary>
        /// Calculates the third term of the formula.
        /// </summary>
        /// <returns>The calculated result of the third term.</returns>
        double CalculateTerm3();

        /// <summary>
        /// Calculates the fourth term of the formula.
        /// </summary>
        /// <returns>The calculated result of the fourth term.</returns>
        double CalculateTerm4();

        /// <summary>
        /// Retrieves the string representation of the formula.
        /// </summary>
        /// <returns>The formula as a string.</returns>
        string GetFormula();
    }
}
