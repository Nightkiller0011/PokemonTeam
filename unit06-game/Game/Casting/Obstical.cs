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
        private string _message = "O";
        public Obstical(string obsticle)
        {
            // create the player
            Cast cast = new Cast();

            SetText(_message);

            SetFontSize(Constants.FONT_SIZE);

            if (obsticle == "obstical")
            {
                SetColor(Constants.RED);
                SetPosition(new Point(rand.Next(0,900), rand.Next(0,600)));
            }
            if (obsticle == "obstical2")
            {
                SetColor(Constants.RED);
                SetPosition(new Point(rand.Next(0,900), rand.Next(0,600)));
            }
            if (obsticle == "obstical3")
            {
                SetColor(Constants.RED);
                SetPosition(new Point(rand.Next(0,900), rand.Next(0,600)));
            }
            
        }

    }
}