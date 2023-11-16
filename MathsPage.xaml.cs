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
    public sealed partial class MathsPage : Page
    {
        private List<string> funFacts = new List<string>
    {
        "A googol is a massive number, 10 to the power of 100. But a googolplex is 10 to the power of a googol, or 10^(10^100). It's so astronomically large that if you were to write it out in full, the number of digits would far exceed the total number of particles in the observable universe.",
        "The golden ratio (approximately 1.618) is a mathematical constant that appears in various natural phenomena, such as the arrangement of leaves on a stem, the spiral of a seashell, and the proportions of the human face. This concept seems to be a hidden aesthetic principle embedded in the natural world.",
        "It took over 350 years for someone to prove Fermat's Last Theorem, which said there are no three positive integers a, b, and c that satisfy the equation a^n + b^n = c^n for any integer value of n greater than 2. Andrew Wiles solved it in 1994, the solution required concepts that were way ahead of Fermat's time.",
        // Add more fun facts here
    };

        private Random random = new Random();
        private DispatcherTimer timer = new DispatcherTimer();
        public MathsPage()
        {
            this.InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(5); // Set the timer interval to 30 seconds
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
