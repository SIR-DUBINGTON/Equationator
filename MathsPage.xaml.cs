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
    /// MathsPage class represents a page that provides mathematical fun facts.
    /// </summary>
    public sealed partial class MathsPage : Page
    {
        // List of mathematical fun facts
        private List<string> funFacts = new List<string>
        {
            "A googol is a massive number, 10 to the power of 100. But a googolplex is 10 to the power of a googol, or 10^(10^100). It's so astronomically large that if you were to write it out in full, the number of digits would far exceed the total number of particles in the observable universe.",
            "The golden ratio (approximately 1.618) is a mathematical constant that appears in various natural phenomena, such as the arrangement of leaves on a stem, the spiral of a seashell, and the proportions of the human face. This concept seems to be a hidden aesthetic principle embedded in the natural world.",
            "It took over 350 years for someone to prove Fermat's Last Theorem, which said there are no three positive integers a, b, and c that satisfy the equation a^n + b^n = c^n for any integer value of n greater than 2. Andrew Wiles solved it in 1994, the solution required concepts that were way ahead of Fermat's time.",
            // Add more fun facts here
        };

        // Random number generator for selecting a random fun fact
        private Random random = new Random();

        // DispatcherTimer for periodically updating the displayed fun fact
        private DispatcherTimer timer = new DispatcherTimer();

        // Constructor for MathsPage
        public MathsPage()
        {
            // Initialize the page components
            this.InitializeComponent();

            // Set the timer interval to 30 seconds
            timer.Interval = TimeSpan.FromSeconds(30);

            // Attach the Timer_Tick method to the Tick event
            timer.Tick += Timer_Tick;

            // Start the timer
            timer.Start();
        }

        // Event handler for the timer tick event
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

        // Event handler for navigating to the MathsPage (refreshing the fun fact)
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
