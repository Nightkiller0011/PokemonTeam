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

            if (obsticle == "obstical")
            {
                
                SetPosition(new Point(x, y));
            }
            else if (obsticle == "obstical2")
            {
                
                SetPosition(new Point(x, y));
            }
            else if (obsticle == "obstical3")
            {
                
                SetPosition(new Point(x, y));
            }
            
        }

    }
}