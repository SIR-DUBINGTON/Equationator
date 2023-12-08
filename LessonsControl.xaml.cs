// Import necessary namespaces
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Playback;
using Windows.UI.Xaml;
using Windows.Media.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// Namespace for the application
namespace Equationator
{
    /// <summary>
    /// LessonsControl class represents a page for controlling and playing lessons.
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LessonsControl : Page
    {
        // MediaPlayer for playing audio/video lessons
        private MediaPlayer mediaPlayer;

        /// <summary>
        /// Constructor for the LessonsControl class.
        /// Initializes the page components and sets up the MediaPlayer and event handlers.
        /// </summary>
        public LessonsControl()
        {
            // Initialize the page components (UI elements)
            this.InitializeComponent();

            // Get the MediaPlayer from the mediaPlayerElement
            mediaPlayer = mediaPlayerElement.MediaPlayer;

            // Attach event handlers to UI buttons and media player events
            PlayButton.Click += PlayButton_Click;
            PauseButton.Click += PauseButton_Click;
            ScrubForwardButton.Click += ScrubForwardButton_Click;
            ScrubBackwardButton.Click += ScrubBackwardButton_Click;
            mediaPlayer.PlaybackSession.PositionChanged += PlaybackSession_PositionChanged;
        }

        /// <summary>
        /// Event handler for the PlayButton's click event.
        /// Plays the media using the MediaPlayer.
        /// </summary>
        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }

        /// <summary>
        /// Event handler for the PauseButton's click event.
        /// Pauses the media using the MediaPlayer.
        /// </summary>
        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }

        /// <summary>
        /// Event handler for the ScrubForwardButton's click event.
        /// Seeks forward in the media playback session.
        /// </summary>
        private void ScrubForwardButton_Click(object sender, RoutedEventArgs e)
        {
            // Seek forward (e.g., 10 seconds)
            mediaPlayer.PlaybackSession.Position += TimeSpan.FromSeconds(10);
        }

        /// <summary>
        /// Event handler for the ScrubBackwardButton's click event.
        /// Seeks backward in the media playback session.
        /// </summary>
        private void ScrubBackwardButton_Click(object sender, RoutedEventArgs e)
        {
            // Seek backward (e.g., 10 seconds)
            mediaPlayer.PlaybackSession.Position -= TimeSpan.FromSeconds(10);
        }

        /// <summary>
        /// Event handler for the PlaybackSession's PositionChanged event.
        /// Updates a seek bar or progress indicator as the position changes.
        /// </summary>
        private void PlaybackSession_PositionChanged(MediaPlaybackSession sender, object args)
        {
            // Update a seek bar or progress indicator as the position changes
            // Example: seekBar.Value = sender.Position.TotalSeconds;
        }
    }
}
