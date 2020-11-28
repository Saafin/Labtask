using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radioplayer
{
    class Ipod : IMusicPlayer
    {
        public void Play(bool on)
        {
            Console.WriteLine("Music playing");
        }

        public void PlayNext()
        {
            Console.WriteLine("Playing next track");
        }

        public void PlayPrevious()
        {
            Console.WriteLine("Playing previous track");
        }

        public void SetVolume(int loudness)
        {
            Console.WriteLine("Volume set to " + loudness);
        }

        public void Switch(bool on)
        {
            Console.WriteLine("Turning switch ON");
        }
    }
}
