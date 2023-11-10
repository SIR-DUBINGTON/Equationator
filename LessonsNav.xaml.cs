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
    public sealed partial class LessonsNav : Page
    {
        public LessonsNav()
        {
            this.InitializeComponent();
        }

        private void OnNavigationViewItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                // Handle settings click if needed
            }
            else
            {
                // Navigate to the selected page
                NavigationViewItem selectedItem = args.InvokedItem as NavigationViewItem;
                if (selectedItem != null)
                {
                    switch (selectedItem.Tag.ToString())
                    {
                        case "Physics":
                            Frame.Navigate(typeof(PhysicsPage));
                            break;
                        case "Maths":
                            Frame.Navigate(typeof(MathsPage));
                            break;
                        case "Astrophysics":
                            Frame.Navigate(typeof(AstroPage));
                            break;

                    }
                }
            }
        }

        private void OnNavigationViewLoaded(object sender, RoutedEventArgs e)
        {
            // Set focus to the NavigationView
            navigationView.Focus(FocusState.Programmatic);
        }

    }
}
