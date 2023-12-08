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
    /// SolveSchwarszchildRadius is a class representing a page for solving Schwarszchild Radius equations.
    /// </summary>
    public sealed partial class SolveSchwarszchildRadius : Page
    {
        /// <summary>
        /// Constructor for the SolveSchwarszchildRadius class.
        /// </summary>
        public SolveSchwarszchildRadius()
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
            GravitationalConstantTextBox.Text = string.Empty;
            MassTextBox.Text = string.Empty;
            // You may add similar lines for other TextBox fields if needed
            ResultTextBlock.Text = string.Empty;
        }

        /// <summary>
        /// Method to calculate and display the result using a given formula.
        /// </summary>
        public void CalculateAndDisplay(IFormula formula)
        {
            double result = formula.Calculate();
            string formulaExpression = formula.GetFormula();

            // Display or use the result and formula expression as needed
        }

        /// <summary>
        /// Method to create a formula based on the formula type and parameters.
        /// </summary>
        public IFormula CreateFormula(string formulaType, params double[] parameters)
        {
            switch (formulaType)
            {
                case "Radius":
                    return new SchwarszchildRadius(parameters[1], parameters[2], parameters[0]);
                // Add cases for other formula types
                default:
                    throw new ArgumentException("Invalid formula type");
            }
        }

        /// <summary>
        /// Event handler for the "Calculate" button click.
        /// Gets user input, creates a formula instance, performs the calculation, and displays the result.
        /// </summary>
        private void OnCalculateClicked(object sender, RoutedEventArgs e)
        {
            // Get user input
            if (double.TryParse(GravitationalConstantTextBox.Text, out double G) && double.TryParse(MassTextBox.Text, out double M) && double.TryParse(MassTextBox.Text, out double r))
            {
                // Create the formula instance
                IFormula formula = CreateFormula("Radius", G, M, r);

                // Perform the calculation
                double result = formula.Calculate();

                // Display the result
                ResultTextBlock.Text = $"Result: {result} metres, m";
            }
            else
            {
                ResultTextBlock.Text = "Invalid input. Please enter valid numbers for force and gravity.";
            }
        }
    }
}
