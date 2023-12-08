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
    /// SolverPage is a class representing the main page with navigation buttons for different solver categories.
    /// </summary>
    public sealed partial class SolverPage : Page
    {
        /// <summary>
        /// Constructor for the SolverPage class.
        /// </summary>
        public SolverPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Event handler for the "Physics" button click.
        /// Navigates to the PhysicsSolverPage when the button is clicked.
        /// </summary>
        private void PhysicsButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PhysicsSolverPage));
        }

        /// <summary>
        /// Event handler for the "Math" button click.
        /// Navigates to the MathSolverPage when the button is clicked.
        /// </summary>
        private void MathButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MathSolverPage));
        }

        /// <summary>
        /// Event handler for the "Astro" button click.
        /// Navigates to the AstroSolverPage when the button is clicked.
        /// </summary>
        private void AstroButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AstroSolverPage));
        }
    }
}
