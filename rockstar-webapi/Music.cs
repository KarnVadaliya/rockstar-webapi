using System;
using System.IO;

namespace rockstar_webapi
{
    public class Music
    {
        public string Demons { get; set; }

        public string InYourEyes { get; set; }

        public Music()
        {
            if(File.Exists("demons.txt"))
            {
                Demons = File.ReadAllText("demons.txt");
            }
            else
            {
                Demons = "??";
            }
            if (File.Exists("inyoureyes.txt"))
            {
                InYourEyes = File.ReadAllText("inyoureyes.txt");
            }
            else
            {
                InYourEyes = "??";
            }
        }
    }
}
