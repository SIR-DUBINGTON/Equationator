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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;


// Namespace for the application
namespace Equationator
{
    /// <summary>
    /// LessonsPage class represents a page that provides navigation to different lesson pages.
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LessonsPage : Page
    {
        /// <summary>
        /// Constructor for the LessonsPage class.
        /// Initializes the page components.
        /// </summary>
        public LessonsPage()
        {
            // Initialize the page components (UI elements)
            this.InitializeComponent();
        }

        /// <summary>
        /// Event handler for the PhysicsButton's click event.
        /// Navigates to the PhysicsPage.
        /// </summary>
        private void PhysicsButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PhysicsPage));
        }

        /// <summary>
        /// Event handler for the MathButton's click event.
        /// Navigates to the MathsPage.
        /// </summary>
        private void MathButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MathsPage));
        }

        /// <summary>
        /// Event handler for the AstroButton's click event.
        /// Navigates to the AstroPage.
        /// </summary>
        private void AstroButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AstroPage));
        }
    }
}
