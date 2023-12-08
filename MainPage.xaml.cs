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
    /// MainPage class represents the main page of the Equationator application.
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        /// <summary>
        /// Constructor for the MainPage class.
        /// Initializes the page components.
        /// </summary>
        public MainPage()
        {
            // Initialize the page components (UI elements)
            this.InitializeComponent();
        }

        /// <summary>
        /// Event handler for the LessonsButton's click event.
        /// Navigates to the "Lessons" page.
        /// </summary>
        private void LessonsButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the "Lessons" page
            Frame.Navigate(typeof(LessonsPage));
        }

        /// <summary>
        /// Event handler for the SolverButton's click event.
        /// Navigates to the "Solver" page.
        /// </summary>
        private void SolverButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the "Solver" page
            Frame.Navigate(typeof(SolverPage));
        }

        /// <summary>
        /// Event handler for the SettingsButton's click event.
        /// Navigates to the "Settings" page.
        /// </summary>
        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the "Settings" page
            Frame.Navigate(typeof(SettingsPage));
        }

        /// <summary>
        /// Event handler for the HelpButton's click event.
        /// Navigates to the "Help" page.
        /// </summary>
        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the "Help" page
            Frame.Navigate(typeof(HelpPage));
        }

        /// <summary>
        /// Event handler for the AboutButton's click event.
        /// Navigates to the "About" page.
        /// </summary>
        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the "About" page
            Frame.Navigate(typeof(AboutPage));
        }

        /// <summary>
        /// Event handler for the ExitButton's click event.
        /// Closes the app.
        /// </summary>
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            // Close the app
            Application.Current.Exit();
        }
    }
}
