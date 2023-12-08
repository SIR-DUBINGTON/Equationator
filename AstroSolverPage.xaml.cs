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


// Namespace for the application
namespace Equationator
{
    /// <summary>
    /// AstroSolverPage class represents a page for solving various astronomy-related equations.
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AstroSolverPage : Page
    {
        /// <summary>
        /// Constructor for the AstroSolverPage class.
        /// Initializes the page components.
        /// </summary>
        public AstroSolverPage()
        {
            // Initialize the page components (UI elements)
            this.InitializeComponent();
        }

        // Event handlers for different equation solving buttons

        private void SolveForSchwarszchildRadius_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the SolveSchwarszchildRadius page
            Frame.Navigate(typeof(SolveSchwarszchildRadius));
        }

        private void SolveForSchwarszchildGravity_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the SolveSchwarszchildGravity page
            Frame.Navigate(typeof(SolveSchwarszchildGravity));
        }

        private void SolveForSchwarszchildMass_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the SolveSchwarszchildMass page
            Frame.Navigate(typeof(SolveSchwarszchildMass));
        }

        private void SolveForFocalRatio_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the SolveFocalRatio page
            Frame.Navigate(typeof(SolveFocalRatio));
        }

        private void SolveForFocalRatioF_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the SolveFocalRatioF page
            Frame.Navigate(typeof(SolveFocalRatioF));
        }

        private void SolveForFocalRatioD_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the SolveFocalRatioD page
            Frame.Navigate(typeof(SolveFocalRatioD));
        }

        private void SolveForRedshift_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the SolveRedshift page
            Frame.Navigate(typeof(SolveRedshift));
        }

        private void SolveForRedshiftV_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the SolveRedshiftV page
            Frame.Navigate(typeof(SolveRedshiftV));
        }
    }
}
