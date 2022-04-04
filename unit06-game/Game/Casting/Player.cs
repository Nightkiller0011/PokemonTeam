using System;
using Unit06;

namespace Unit06.Game.Casting
{
    /// <summary>
    /// <para>The Player in the game.</para>
    /// </summary>
    public class Player : Actor
    {
        /// <summary>
        /// Constructs a new instance of a Player.
        /// </summary>

        private string _message1 = "#";
        private string _message2 = "&";

        public Player(string player)
        {
            // create the player
            Cast cast = new Cast();


            SetFontSize(Constants.FONT_SIZE);

            if (player == "player1")
            {
                SetText(_message1);
                SetColor(Constants.YELLOW);
                SetPosition(new Point(300, 585));
                setFightClass("knight");
                SetImage("Assats/Assets/knight2.png");
            }
            else if (player == "player2")
            {
                SetText(_message2);
                SetColor(Constants.GREEN);
                SetPosition(new Point(600, 585));
                setFightClass("archer");
                SetImage("Assats/Assets/Archer2.png");
            }
            
        }
    }
}