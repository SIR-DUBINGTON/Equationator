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
    /// SolveForKineticEnergy is a class representing a page to calculate and display kinetic energy using physics formulas.
    /// </summary>
    public sealed partial class SolveForKineticEnergy : Page
    {
        /// <summary>
        /// Constructor for the SolveForKineticEnergy class.
        /// </summary>
        public SolveForKineticEnergy()
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
            MassTextBox.Text = string.Empty;
            VelocityTextBox.Text = string.Empty;
            // You may add similar lines for other TextBox fields if needed
            ResultTextBlock.Text = string.Empty;
        }

        /// <summary>
        /// Calculates and displays the result using the provided formula.
        /// </summary>
        public void CalculateAndDisplay(IFormula formula)
        {
            double result = formula.Calculate();
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
                case "Kinetic Energy":
                    return new PhysicsFormulaKineticEnergy(parameters[2], parameters[1], parameters[0]);
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
            if (double.TryParse(MassTextBox.Text, out double m) && double.TryParse(VelocityTextBox.Text, out double v) && double.TryParse(VelocityTextBox.Text, out double ke))
            {
                // Create the formula instance
                IFormula formula = CreateFormula("Kinetic Energy", m, v, ke);

                // Perform the calculation
                double result = formula.Calculate();

                // Display the result
                ResultTextBlock.Text = $"Result: {result} Newtons, N";
            }
            else
            {
                ResultTextBlock.Text = "Invalid input. Please enter valid numbers for mass and velocity.";
            }
        }
    }
}
