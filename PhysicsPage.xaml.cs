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
    public sealed partial class PhysicsPage : Page
    {
        private List<string> funFacts = new List<string>
    {
        "According to Einstein's theory of relativity, time is relative, and this is demonstrated by the Twin Paradox. If one twin travels into space at near the speed of light and returns, they would age more slowly than the twin who stayed on Earth. This paradox shows the fascinating nature of time dilation.",
        "In the quantum world, particles can exist in multiple states simultaneously, a phenomenon known as superposition. This is famously illustrated by Schrödinger's cat, a thought experiment where a cat inside a sealed box is both alive and dead until the box is opened and the cat's state is observed.",
        // Add more fun facts here
    };

        private Random random = new Random();
        private DispatcherTimer timer = new DispatcherTimer();
        public PhysicsPage()
        {
            this.InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(30); // Set the timer interval to 30 seconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, object e)
        {
            // Display a random fun fact in the TextBox
            int randomIndex = random.Next(funFacts.Count);
            FunFactsTextBox.Text = funFacts[randomIndex];
        }

        private void NavigateToPhysicsPage(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PhysicsPage));
        }

        private void NavigateToMathsPage(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MathsPage));
        }

        private void NavigateToAstroPage(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AstroPage));
        }
    }
}
