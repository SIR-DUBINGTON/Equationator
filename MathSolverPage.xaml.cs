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
    public sealed partial class MathSolverPage : Page
    {
        public MathSolverPage()
        {
            this.InitializeComponent();
        }

        private void SolveForRectangle_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveAreaRectangle));
        }

        private void SolveForRectangleB_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveAreaRectangleB));
        }

        private void SolveForRectangleH_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveAreaRectangleH));
        }

        private void SolveForTrapezoid_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveAreaTrapezoid));
        }

        private void SolveForTrapezoidB_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveAreaTrapezoidB));
        }

        private void SolveForTrapezoidH_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveAreaTrapezoidH));
        }

        private void SolveForTrapezoidW_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveAreaTrapezoidW));
        }

        private void SolveForCircle_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveAreaCircle));
        }

        private void SolveForCircleR_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveAreaCircleR));
        }
    }
}
