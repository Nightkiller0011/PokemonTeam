using System.Collections.Generic;
using System.Reflection.Metadata;
using Raylib_cs;
using Unit06.Game.Casting;

namespace Unit06.Game.Services
{
    public class AudioService
    {
        public AudioService()
        {

        }
        public void playsound(string file)
        {
            Sound audio = Raylib.LoadSound(file);
            Raylib.PlaySound(audio);
            Raylib.UnloadSound(audio);
        }
    }
}