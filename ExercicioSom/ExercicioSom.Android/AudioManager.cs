using System;
using Android.Media;
using Xamarin.Forms;

[assembly: Dependency(typeof(ExercicioSom.Droid.AudioManager))]

namespace ExercicioSom.Droid
{
    public class AudioManager : IAudioManager

    {
        MediaPlayer player;

        public void Play()
        {
             player = MediaPlayer.Create(Android.App.Application.Context, Resource.Raw.Mario_Bros);

            player.Start();
        }
    }
}
