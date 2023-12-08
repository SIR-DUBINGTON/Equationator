// Import necessary namespaces
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
    /// MathSolverPage class represents a page for solving mathematical area equations.
    /// </summary>
    public sealed partial class MathSolverPage : Page
    {
        // Constructor for MathSolverPage
        public MathSolverPage()
        {
            // Initialize the page components
            this.InitializeComponent();
        }

        // Event handler for solving the area of a rectangle
        private void SolveForRectangle_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the SolveAreaRectangle page
            Frame.Navigate(typeof(SolveAreaRectangle));
        }

        // Event handler for solving the breadth of a rectangle
        private void SolveForRectangleB_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the SolveAreaRectangleB page
            Frame.Navigate(typeof(SolveAreaRectangleB));
        }

        // Event handler for solving the height of a rectangle
        private void SolveForRectangleH_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the SolveAreaRectangleH page
            Frame.Navigate(typeof(SolveAreaRectangleH));
        }

        // Event handler for solving the area of a trapezoid
        private void SolveForTrapezoid_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the SolveAreaTrapezoid page
            Frame.Navigate(typeof(SolveAreaTrapezoid));
        }

        // Event handler for solving the breadth of a trapezoid
        private void SolveForTrapezoidB_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the SolveAreaTrapezoidB page
            Frame.Navigate(typeof(SolveAreaTrapezoidB));
        }

        // Event handler for solving the height of a trapezoid
        private void SolveForTrapezoidH_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the SolveAreaTrapezoidH page
            Frame.Navigate(typeof(SolveAreaTrapezoidH));
        }

        // Event handler for solving the top width of a trapezoid
        private void SolveForTrapezoidW_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the SolveAreaTrapezoidW page
            Frame.Navigate(typeof(SolveAreaTrapezoidW));
        }

        // Event handler for solving the area of a circle
        private void SolveForCircle_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the SolveAreaCircle page
            Frame.Navigate(typeof(SolveAreaCircle));
        }

        // Event handler for solving the radius of a circle
        private void SolveForCircleR_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the SolveAreaCircleR page
            Frame.Navigate(typeof(SolveAreaCircleR));
        }
    }
}
