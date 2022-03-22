using System;


namespace Unit06.Game.Casting
{
    /// <summary>
    /// <para>The Player in the game.</para>
    /// </summary>
    public class Enemy : Actor
    {
        private string _message = "E";
        public Enemy(string enemy)
        {
            // create the player
            Cast cast = new Cast();

            SetText(_message);

            SetFontSize(Constants.FONT_SIZE);

            if (enemy == "enemy")
            {
                SetColor(Constants.RED);
                SetPosition(new Point(150, 20));
            }
            
        }

    }
}