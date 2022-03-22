using System;


namespace Unit06.Game.Casting
{
    /// <summary>
    /// <para>The Player in the game.</para>
    /// </summary>
    public class Obsticle : Actor
    {
        private string _message = "O";
        public Obsticle(string obsticle)
        {
            // create the player
            Cast cast = new Cast();

            SetText(_message);

            SetFontSize(Constants.FONT_SIZE);

            if (obsticle == "obsticle")
            {
                SetColor(Constants.RED);
                SetPosition(new Point(300, 575));
            }
            
        }

    }
}