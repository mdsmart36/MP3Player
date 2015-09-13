using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer2
{
    class mp3Player
    {
        //comment

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);

        public void open (string file)
        {
            // issue commands to open a file
            string command = "open \"" + file + "\" type MPEGVideo alias MyMp3";
            mciSendString(command, null, 0, 0);
        }

        public void play ()
        {
            // issue commands to play a file
            string command = "play MyMp3";
            mciSendString(command, null, 0, 0);
        }

        public void stop ()
        {
            // issue commands to stop and close a file
            string command = "stop MyMp3";
            mciSendString(command, null, 0, 0);

            command = "close MyMp3";
            mciSendString(command, null, 0, 0);
        }
    }
}
