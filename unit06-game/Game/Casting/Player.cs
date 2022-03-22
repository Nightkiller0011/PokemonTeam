using System;


namespace Unit06.Game.Casting
{
    /// <summary>
    /// <para>The Player in the game.</para>
    /// </summary>
    public class Player : Actor
    {
        private int points = 0;

        /// <summary>
        /// Constructs a new instance of a Player.
        /// </summary>

        private string _message = "#";

        public Player(string player)
        {
            // create the player
            Cast cast = new Cast();

            SetText(_message);

            SetFontSize(Constants.FONT_SIZE);

            if (player == "player1")
            {
                SetColor(Constants.RED);
                SetPosition(new Point(300, 575));
            }
            else if (player == "player2")
            {
                SetColor(Constants.GREEN);
                SetPosition(new Point(600, 575));
            }
        }
    }
}