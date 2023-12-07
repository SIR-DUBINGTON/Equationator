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
    public sealed partial class AstroSolverPage : Page
    {
        public AstroSolverPage()
        {
            this.InitializeComponent();
        }

        private void SolveForSchwarszchildRadius_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveSchwarszchildRadius));
        }

        private void SolveForSchwarszchildGravity_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveSchwarszchildGravity));
        }

        private void SolveForSchwarszchildMass_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveSchwarszchildMass));
        }

        private void SolveForFocalRatio_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveFocalRatio));
        }

        private void SolveForFocalRatioF_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveFocalRatioF));
        }

        private void SolveForFocalRatioD_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveFocalRatioD));
        }

        private void SolveForRedshift_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveRedshift));
        }

        private void SolveForRedshiftV_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveRedshiftV));
        }
    }
}
