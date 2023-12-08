using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace Equationator
{
    /// <summary>
    /// SettingsPage is a class that represents the settings page of the application.
    /// </summary>
    public sealed partial class SettingsPage : Page
    {
        /// <summary>
        /// Constructor for the SettingsPage class.
        /// </summary>
        public SettingsPage()
        {
            this.InitializeComponent();
            DataContext = this; // Set the DataContext to the current page to enable x:Bind
        }

        private bool _isFullscreenEnabled;

        /// <summary>
        /// Property to get or set whether fullscreen mode is enabled.
        /// </summary>
        public bool IsFullscreenEnabled
        {
            get => _isFullscreenEnabled;
            set
            {
                if (_isFullscreenEnabled != value)
                {
                    _isFullscreenEnabled = value;

                    // Implement logic to enter or exit fullscreen mode based on the value.
                    // You may use the Windows.UI.ViewManagement.ApplicationView class for this purpose.
                    if (_isFullscreenEnabled)
                    {
                        ApplicationView.GetForCurrentView().TryEnterFullScreenMode();
                    }
                    else
                    {
                        ApplicationView.GetForCurrentView().ExitFullScreenMode();
                    }
                }
            }
        }
    }
}
