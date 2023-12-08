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
    /// SolveForVelocity is a class representing a page to calculate and display velocity using physics formulas.
    /// </summary>
    public sealed partial class SolveForVelocity : Page
    {
        /// <summary>
        /// Constructor for the SolveForVelocity class.
        /// </summary>
        public SolveForVelocity()
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
            InitialVTextBox.Text = string.Empty;
            AccelerationTextBox.Text = string.Empty;
            TimeTextBox.Text = string.Empty;
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
                case "Velocity":
                    return new PhysicsFormulaVelocity(parameters[0], parameters[1], parameters[2], parameters[3]);
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
            if (double.TryParse(InitialVTextBox.Text, out double u) && double.TryParse(AccelerationTextBox.Text, out double a) && double.TryParse(TimeTextBox.Text, out double t) && double.TryParse(TimeTextBox.Text, out double v))
            {
                // Create the formula instance
                IFormula formula = CreateFormula("Velocity", u, a, t, v);

                // Perform the calculation
                double result = formula.Calculate();

                // Display the result
                ResultTextBlock.Text = $"Result: {result} m/s";
            }
            else
            {
                ResultTextBlock.Text = "Invalid input. Please enter valid numbers for force and gravity.";
            }
        }
    }
}
