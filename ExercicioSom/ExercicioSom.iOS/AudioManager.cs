using System;
using AVFoundation;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(ExercicioSom.iOS.AudioManager))]

namespace ExercicioSom.iOS
{
    public class AudioManager : IAudioManager
    {
        AVAudioPlayer player;

        public void Play()
        {

            NSUrl url = new NSUrl("Sons/Mario_Bros.mp3");
            NSError error;
            player = new AVAudioPlayer(url, "mp3", out error);
            player.Volume = 1.0f;
            player.NumberOfLoops = -1;

            player.Play();
        }
    }
}
