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
    /// SolveAreaRectangleH is a class representing a page to calculate and display the height of a rectangle.
    /// </summary>
    public sealed partial class SolveAreaRectangleH : Page
    {
        /// <summary>
        /// Constructor for the SolveAreaRectangleH class.
        /// </summary>
        public SolveAreaRectangleH()
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
            BreadthTextBox.Text = string.Empty;
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
                case "Height":
                    return new MathAreaRectangle(parameters[2], parameters[1], parameters[0]);
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
            if (double.TryParse(AreaTextBox.Text, out double a) && double.TryParse(BreadthTextBox.Text, out double b) && double.TryParse(BreadthTextBox.Text, out double h))
            {
                // Create the formula instance
                IFormula formula = CreateFormula("Height", a, b, h);

                // Perform the calculation
                double result = formula.CalculateTerm3();

                // Display the result
                ResultTextBlock.Text = $"Result: {result} metres, m";
            }
            else
            {
                ResultTextBlock.Text = "Invalid input. Please enter valid numbers for area, breadth, and height.";
            }
        }
    }
}
