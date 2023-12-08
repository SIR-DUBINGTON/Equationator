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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;


namespace Equationator
{
    /// <summary>
    /// UserNav is a class representing a page with a navigation menu.
    /// </summary>
    public sealed partial class UserNav : Page
    {
        /// <summary>
        /// Constructor for the UserNav class.
        /// Initializes the UserNav page and sets the initial position for the rendering transformation.
        /// </summary>
        public UserNav()
        {
            this.InitializeComponent();
            RenderTransform = new TranslateTransform { X = -Width };
        }

        /// <summary>
        /// Event handler for the HamburgerButton click.
        /// Toggles the visibility of the navigation pane.
        /// </summary>
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        /// <summary>
        /// Event handler for the IconsListBox selection change.
        /// Navigates to the selected page based on the ListBoxItem's name.
        /// </summary>
        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            switch (((ListBoxItem)IconsListBox.SelectedItem).Name)
            {
                case "HomeListBoxItem":
                    rootFrame.Navigate(typeof(MainPage));
                    break;
                case "LessonsListBoxItem":
                    rootFrame.Navigate(typeof(LessonsPage));
                    break;
                case "SolverListBoxItem":
                    rootFrame.Navigate(typeof(SolverPage));
                    break;
                case "SettingsListBoxItem":
                    rootFrame.Navigate(typeof(SettingsPage));
                    break;
                case "HelpListBoxItem":
                    rootFrame.Navigate(typeof(HelpPage));
                    break;
                case "AboutListBoxItem":
                    rootFrame.Navigate(typeof(AboutPage));
                    break;
                case "BackButton_Click":
                    if (rootFrame.CanGoBack)
                    {
                        rootFrame.GoBack();
                    }
                    break;
            }
        }
    }
}
