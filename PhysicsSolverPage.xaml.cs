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
    /// PhysicsSolverPage represents a page for solving physics-related problems.
    /// </summary>
    public sealed partial class PhysicsSolverPage : Page
    {
        // Constructor for PhysicsSolverPage
        public PhysicsSolverPage()
        {
            // Initialize the page components
            this.InitializeComponent();
        }

        // Event handler for solving for force
        private void SolveForF_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveForForce));
        }

        // Event handler for solving for mass
        private void SolveForM_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveForMass));
        }

        // Event handler for solving for gravity
        private void SolveForG_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveForGravity));
        }

        // Event handler for solving for velocity
        private void SolveForV_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveForVelocity));
        }

        // Event handler for solving for initial velocity (u)
        private void SolveForU_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveForInitialV));
        }

        // Event handler for solving for acceleration
        private void SolveForA_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveForAcceleration));
        }

        // Event handler for solving for time
        private void SolveForT_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveForTime));
        }

        // Event handler for solving for kinetic energy
        private void SolveForKE_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveForKineticEnergy));
        }

        // Event handler for solving for mass in kinetic energy formula
        private void SolveForMke_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveForMassKineticEnergy));
        }

        // Event handler for solving for velocity in kinetic energy formula
        private void SolveForVKe_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SolveForVelocityKineticEnergy));
        }
    }
}
