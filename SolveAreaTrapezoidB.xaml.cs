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
    /// SolveAreaTrapezoidB is a class representing a page to calculate and display the breadth of a trapezoid.
    /// </summary>
    public sealed partial class SolveAreaTrapezoidB : Page
    {
        /// <summary>
        /// Constructor for the SolveAreaTrapezoidB class.
        /// </summary>
        public SolveAreaTrapezoidB()
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
            AreaTextBox.Text = string.Empty;
            HeightTextBox.Text = string.Empty;
            BreadthTextBox.Text = string.Empty;
            // You may add similar lines for other TextBox fields if needed
            ResultTextBlock.Text = string.Empty;
        }

        /// <summary>
        /// Calculates and displays the result using the provided formula.
        /// </summary>
        public void CalculateAndDisplay(IFormula formula)
        {
            double result = formula.CalculateTerm2();
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
                case "Breadth":
                    return new MathAreaTrapezoid(parameters[3], parameters[1], parameters[2], parameters[0]);
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
            if (double.TryParse(AreaTextBox.Text, out double A) && double.TryParse(HeightTextBox.Text, out double h) && double.TryParse(BreadthTextBox.Text, out double w) && double.TryParse(BreadthTextBox.Text, out double b))
            {
                // Create the formula instance
                IFormula formula = CreateFormula("Breadth", A, h, w, b);

                // Perform the calculation
                double result = formula.CalculateTerm2();

                // Display the result
                ResultTextBlock.Text = $"Result: {result} metres, m";
            }
            else
            {
                ResultTextBlock.Text = "Invalid input. Please enter valid numbers for area, height, breadth, and breadth.";
            }
        }
    }
}
