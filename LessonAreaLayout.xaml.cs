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
    public sealed partial class LessonAreaLayout : Page
    {
        private List<string> funFacts = new List<string>
    {
        "Fun Fact 1: ...",
        "Fun Fact 2: ...",
        "Fun Fact 3: ...",
        // Add more fun facts here
    };

        private Random random = new Random();
        private DispatcherTimer timer = new DispatcherTimer();
        public LessonAreaLayout()
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
    }
}
