using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace Equationator
{
    /// <summary>
    /// SolveForVelocityKineticEnergy is a class representing a page to calculate and display velocity using kinetic energy formulas.
    /// </summary>
    public sealed partial class SolveForVelocityKineticEnergy : Page
    {
        /// <summary>
        /// Constructor for the SolveForVelocityKineticEnergy class.
        /// </summary>
        public SolveForVelocityKineticEnergy()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Event handler for the "Clear" button click.
        /// Clears the content of TextBox fields.
        /// </summary>
        private void OnClearClicked(object sender, RoutedEventArgs e)
        {
            // Clear the content of TextBox fields
            KETextBox.Text = string.Empty;
            MassTextBox.Text = string.Empty;
            // You may add similar lines for other TextBox fields if needed
            ResultTextBlock.Text = string.Empty;
        }

        /// <summary>
        /// Calculates and displays the result using the provided formula.
        /// </summary>
        public void CalculateAndDisplay(IFormula formula)
        {
            double result = formula.CalculateTerm3();
            string formulaExpression = formula.GetFormula();

            // Display or use the result and formula expression as needed
        }

        /// <summary>
        /// Creates an instance of the specified formula type with the given parameters.
        /// </summary>
        public IFormula CreateFormula(string formulaType, params double[] parameters)
        {
            switch (formulaType)
            {
                case "Velocity":
                    return new PhysicsFormulaKineticEnergy(parameters[0], parameters[2], parameters[1]);
                // Add cases for other formula types
                default:
                    throw new ArgumentException("Invalid formula type");
            }
        }

        /// <summary>
        /// Event handler for the "Calculate" button click.
        /// Retrieves user input, creates a formula, performs the calculation, and displays the result.
        /// </summary>
        private void OnCalculateClicked(object sender, RoutedEventArgs e)
        {
            // Get user input
            if (double.TryParse(KETextBox.Text, out double ke) && double.TryParse(MassTextBox.Text, out double m) && double.TryParse(MassTextBox.Text, out double v))
            {
                // Create the formula instance
                IFormula formula = CreateFormula("Velocity", ke, v, m);

                // Perform the calculation
                double result = formula.CalculateTerm3();

                // Display the result
                ResultTextBlock.Text = $"Result: {result} Kilograms, kg";
            }
            else
            {
                ResultTextBlock.Text = "Invalid input. Please enter valid numbers for force and gravity.";
            }
        }
    }
}
