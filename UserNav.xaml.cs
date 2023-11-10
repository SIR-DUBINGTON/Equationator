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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Equationator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UserNav : Page
    {
        public UserNav()
        {
            this.InitializeComponent();
            RenderTransform = new TranslateTransform { X = -Width };
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

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
