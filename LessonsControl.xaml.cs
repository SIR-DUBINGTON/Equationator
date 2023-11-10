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


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Equationator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LessonsControl : Page
    {
        private MediaPlayer mediaPlayer;
        public LessonsControl()
        {
            this.InitializeComponent();

            mediaPlayer = mediaPlayerElement.MediaPlayer;

            // Attach event handlers
            PlayButton.Click += PlayButton_Click;
            PauseButton.Click += PauseButton_Click;
            ScrubForwardButton.Click += ScrubForwardButton_Click;
            ScrubBackwardButton.Click += ScrubBackwardButton_Click;
            mediaPlayer.PlaybackSession.PositionChanged += PlaybackSession_PositionChanged;


        }


        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void ScrubForwardButton_Click(object sender, RoutedEventArgs e)
        {
            // Seek forward (e.g., 10 seconds)
            mediaPlayer.PlaybackSession.Position += TimeSpan.FromSeconds(10);
        }

        private void ScrubBackwardButton_Click(object sender, RoutedEventArgs e)
        {
            // Seek backward (e.g., 10 seconds)
            mediaPlayer.PlaybackSession.Position -= TimeSpan.FromSeconds(10);
        }

        private void PlaybackSession_PositionChanged(MediaPlaybackSession sender, object args)
        {
            // Update a seek bar or progress indicator as the position changes
            // Example: seekBar.Value = sender.Position.TotalSeconds;
        }

    }
}
