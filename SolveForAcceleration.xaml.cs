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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Equationator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SolveForAcceleration : Page
    {
        public SolveForAcceleration()
        {
            this.InitializeComponent();
        }
        private void OnClearClicked(object sender, RoutedEventArgs e)
        {
            // Clear the content of TextBox fields
            InitialVTextBox.Text = string.Empty;
            VelocityTextBox.Text = string.Empty;
            TimeTextBox.Text = string.Empty;
            // You may add similar lines for other TextBox fields if needed
            ResultTextBlock.Text = string.Empty;
        }

        public void CalculateAndDisplay(IFormula formula)
        {
            double result = formula.CalculateTerm3();
            string formulaExpression = formula.GetFormula();

            // Display or use the result and formula expression as needed
        }

        public IFormula CreateFormula(string formulaType, params double[] parameters)
        {
            switch (formulaType)
            {
                case "Acceleration":
                    return new PhysicsFormulaVelocity(parameters[0], parameters[1], parameters[2], parameters[3]);
                // Add cases for other formula types
                default:
                    throw new ArgumentException("Invalid formula type");
            }
        }


        private void OnCalculateClicked(object sender, RoutedEventArgs e)
        {
            // Get user input
            if (double.TryParse(InitialVTextBox.Text, out double u) && double.TryParse(VelocityTextBox.Text, out double v) && double.TryParse(TimeTextBox.Text, out double t) && double.TryParse(TimeTextBox.Text, out double a))
            {
                // Create the formula instance
                IFormula formula = CreateFormula("Acceleration", u, a, t, v);

                // Perform the calculation
                double result = formula.CalculateTerm3();

                // Display the result
                ResultTextBlock.Text = $"Result: {result} m/s^2";
            }
            else
            {
                ResultTextBlock.Text = "Invalid input. Please enter valid numbers for force and gravity.";
            }
        }
    }
}

