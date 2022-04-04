using System;
using System.Collections.Generic;

namespace Unit06.Game.Casting
{
    /// <summary>
    /// <para>The Player in the game.</para>
    /// </summary>
    public class Obstical : Actor
    {
        Random rand = new Random();
        // private string _message = "O";

        List<string> n = new List<string>(2){"a", "b"};
        
        public Obstical(string obsticle, string message)
        {

            int x = 0;
            int y = 0;

            Random rand = new Random();

            x = rand.Next(0,60) * 15;
            y = rand.Next(3,40) * 15;

            // create the player
            Cast cast = new Cast();

            SetText(message);

            SetFontSize(Constants.FONT_SIZE);

            SetPosition(new Point(x, y));
            
            SetPosition(new Point(x, y));
            CreateImage(message);
        }
         public void CreateImage(string messages)
        {
            if (messages == "W")
            {
                SetImage("Assats/Assets/wall.png");
            }
            else if (messages == "B")
            {
                SetImage("Assats/Assets/barrel.png");
            }
            else if (messages == "R")
            {
                SetImage("Assats/Assets/rock.png");
            }
        }

    }
}