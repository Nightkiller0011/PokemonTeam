using System;

namespace Unit06.Game.Casting
{
    /// <summary>
    /// <para>The Player in the game.</para>
    /// </summary>
    public class GameOver : Actor
    {
        /// <summary>
        /// Constructs a new instance of a Player.
        /// </summary>

        private string _message = "";

        public GameOver()
        {
            // create the player
            Cast cast = new Cast();

            SetFontSize(Constants.FONT_SIZE);
            SetText(_message);
            SetColor(Constants.YELLOW);
            SetPosition(new Point(350, 300));
        }
    }
}
