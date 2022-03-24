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
            Random rand = new Random();
            // create the player
            Cast cast = new Cast();

            SetText(messages);

            SetFontSize(Constants.FONT_SIZE);

            if (enemy == "enemy")
            {
                SetColor(Constants.RED);
                SetPosition(new Point(rand.Next(0,900), rand.Next(0,600)));
            }
            else if(enemy == "enemy2")
            {
                SetColor(Constants.RED);
                SetPosition(new Point(rand.Next(0,900), rand.Next(0,600)));
            }
            else if (enemy == "enemy3")
            {
                SetColor(Constants.RED);
                SetPosition(new Point(rand.Next(0,900), rand.Next(0,600)));
            }
            {
                
            }
            
        }

    }
}