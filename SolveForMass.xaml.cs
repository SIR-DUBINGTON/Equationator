﻿using System;
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
    public sealed partial class SolveForMass : Page
    {
        public SolveForMass()
        {
            this.InitializeComponent();
        }

        private void OnClearClicked(object sender, RoutedEventArgs e)
        {
            // Clear the content of TextBox fields
            ForceTextBox.Text = string.Empty;
            GravityTextBox.Text = string.Empty;
            // You may add similar lines for other TextBox fields if needed
            ResultTextBlock.Text = string.Empty;
        }

        public void CalculateAndDisplay(IFormula formula)
        {
            double result = formula.CalculateTerm2();
            string formulaExpression = formula.GetFormula();

            // Display or use the result and formula expression as needed
        }

        public IFormula CreateFormula(string formulaType, params double[] parameters)
        {
            switch (formulaType)
            {
                case "Mass":
                    return new PhysicsFormulas(parameters[0], parameters[1], parameters[2]);
                // Add cases for other formula types
                default:
                    throw new ArgumentException("Invalid formula type");
            }
        }


        private void OnCalculateClicked(object sender, RoutedEventArgs e)
        {
            // Get user input
            if (double.TryParse(ForceTextBox.Text, out double f) && double.TryParse(GravityTextBox.Text, out double g) && double.TryParse(GravityTextBox.Text, out double m))
            {
                // Create the formula instance
                IFormula formula = CreateFormula("Mass", m, g, f);

                // Perform the calculation
                double result = formula.CalculateTerm2();

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
