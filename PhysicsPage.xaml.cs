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
    /// PhysicsPage represents a page dedicated to physics-related content.
    /// </summary>
    public sealed partial class PhysicsPage : Page
    {
        // List of fun facts related to physics
        private List<string> funFacts = new List<string>
        {
            "According to Einstein's theory of relativity, time is relative, and this is demonstrated by the Twin Paradox. If one twin travels into space at near the speed of light and returns, they would age more slowly than the twin who stayed on Earth. This paradox shows the fascinating nature of time dilation.",
            "In the quantum world, particles can exist in multiple states simultaneously, a phenomenon known as superposition. This is famously illustrated by Schrödinger's cat, a thought experiment where a cat inside a sealed box is both alive and dead until the box is opened and the cat's state is observed.",
            // Add more fun facts here
        };

        // Random object for selecting random fun facts
        private Random random = new Random();

        // DispatcherTimer for periodically updating the displayed fun fact
        private DispatcherTimer timer = new DispatcherTimer();

        // Constructor for PhysicsPage
        public PhysicsPage()
        {
            // Initialize the page components
            this.InitializeComponent();

            // Set the timer interval to 30 seconds
            timer.Interval = TimeSpan.FromSeconds(30);

            // Attach the Timer_Tick method to the Tick event of the timer
            timer.Tick += Timer_Tick;

            // Start the timer
            timer.Start();
        }

        // Event handler for the timer Tick event
        private void Timer_Tick(object sender, object e)
        {
            // Display a random fun fact in the TextBox
            int randomIndex = random.Next(funFacts.Count);
            FunFactsTextBox.Text = funFacts[randomIndex];
        }

        // Event handler for navigating to the PhysicsPage
        private void NavigateToPhysicsPage(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PhysicsPage));
        }

        // Event handler for navigating to the MathsPage
        private void NavigateToMathsPage(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MathsPage));
        }

        // Event handler for navigating to the AstroPage
        private void NavigateToAstroPage(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AstroPage));
        }
    }
}
