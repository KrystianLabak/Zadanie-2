using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Zadanie_2.Interfejs;

namespace Zadanie_2
{
    class Interfejs
    {
        public interface IPlayable
        {
            void Play();
        }
    }
    class MusicPlayer : IPlayable
    {
        string songName;
        public MusicPlayer(string songName)
        {
            this.songName = songName;
        }

        public void Play()
        {
            Console.WriteLine("Odtwarzam utwór: " + songName);
        }
    }
    class VideoPlayer : IPlayable
    {
        string VideoName;
        public VideoPlayer(string VideoName)
        {
            this.VideoName = VideoName;
        }

        public void Play()
        {
            Console.WriteLine("Odtwarzam film: " + VideoName);
        }
    }
}
