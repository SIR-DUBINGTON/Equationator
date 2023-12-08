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
    /// LessonAreaLayout class represents a page with a layout for lessons and fun facts.
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LessonAreaLayout : Page
    {
        // List of fun facts to be displayed on the page
        private List<string> funFacts = new List<string>
        {
            "Fun Fact 1: ...",
            "Fun Fact 2: ...",
            "Fun Fact 3: ...",
            // Add more fun facts here
        };

        // Random number generator for selecting random fun facts
        private Random random = new Random();

        // Timer for updating the displayed fun fact at regular intervals
        private DispatcherTimer timer = new DispatcherTimer();

        /// <summary>
        /// Constructor for the LessonAreaLayout class.
        /// Initializes the page components, sets up the timer, and starts it.
        /// </summary>
        public LessonAreaLayout()
        {
            // Initialize the page components (UI elements)
            this.InitializeComponent();

            // Set the timer interval to 5 seconds
            timer.Interval = TimeSpan.FromSeconds(5);

            // Attach the Timer_Tick method to the Tick event of the timer
            timer.Tick += Timer_Tick;

            // Start the timer
            timer.Start();
        }

        /// <summary>
        /// Event handler for the timer tick.
        /// Displays a random fun fact in the TextBox.
        /// </summary>
        private void Timer_Tick(object sender, object e)
        {
            // Display a random fun fact in the TextBox
            int randomIndex = random.Next(funFacts.Count);
            FunFactsTextBox.Text = funFacts[randomIndex];
        }
    }
}
