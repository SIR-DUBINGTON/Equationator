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
    /// SolveForGravity is a class representing a page to calculate and display gravity using physics formulas.
    /// </summary>
    public sealed partial class SolveForGravity : Page
    {
        /// <summary>
        /// Constructor for the SolveForGravity class.
        /// </summary>
        public SolveForGravity()
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
            ForceTextBox.Text = string.Empty;
            MassTextBox.Text = string.Empty;
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
                case "Gravity":
                    return new PhysicsFormulas(parameters[0], parameters[1], parameters[2]);
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
            if (double.TryParse(ForceTextBox.Text, out double f) && double.TryParse(MassTextBox.Text, out double m) && double.TryParse(MassTextBox.Text, out double g))
            {
                // Create the formula instance
                IFormula formula = CreateFormula("Gravity", m, g, f);

                // Perform the calculation
                double result = formula.CalculateTerm3();

                // Display the result
                ResultTextBlock.Text = $"Result: {result} m/s^2";
            }
            else
            {
                ResultTextBlock.Text = "Invalid input. Please enter valid numbers for force and mass.";
            }
        }
    }
}
