using System;


namespace Unit06.Game.Casting
{
    /// <summary>
    /// <para>The Player in the game.</para>
    /// </summary>
    public class Enemy : Actor
    {
        //private string _message1 = "E";
        public Enemy(string enemy, string messages)
        {
            // create the player
            Cast cast = new Cast();

            SetText(messages);

            SetFontSize(Constants.FONT_SIZE);

            if (enemy == "enemy")
            {
                SetColor(Constants.RED);
                SetPosition(new Point(150, 20));
            }
            else if(enemy == "enemy2")
            {
                SetColor(Constants.RED);
                SetPosition(new Point(200, 20));
            }
            else if (enemy == "enemy3")
            {
                SetColor(Constants.RED);
                SetPosition(new Point(400, 20));
            }
            {
                
            }
            
        }

    }
}