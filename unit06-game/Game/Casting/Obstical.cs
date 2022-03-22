using System;


namespace Unit06.Game.Casting
{
    /// <summary>
    /// <para>The Player in the game.</para>
    /// </summary>
    public class Obstical : Actor
    {
        private string _message = "O";
        public Obstical(string obsticle)
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