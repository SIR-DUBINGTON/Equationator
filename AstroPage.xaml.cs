using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
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
    public sealed partial class AstroPage : Page
    {
        private List<string> funFacts = new List<string>
        {
        "Black holes, can actually 'sing'. Scientists have converted the gravitational waves emitted by merging black holes into audible frequencies. The resulting sounds, often described as chirps or thuds, provide a unique auditory perspective on these cosmic events.",
        "Astrophysicists theorize that within the atmospheres of Neptune and Uranus, it rains diamonds. These ice giant planets have extreme pressure and temperatures, causing carbon atoms to compress and form diamond crystals. This phenomenon gives new meaning to the phrase \"diamonds are forever\".",
        "Astrophysicists estimate that about 85% of the matter in the universe is composed of dark matter, an enigmatic substance that neither emits, absorbs, nor reflects light. It remains invisible. Unraveling its mysteries is a compelling challenge, once solved, could revolutionize our understanding of the universe.",
        // Add more fun facts here
    };

        private Random random = new Random();
        private DispatcherTimer timer = new DispatcherTimer();
        public AstroPage()
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
