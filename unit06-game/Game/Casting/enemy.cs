using System;


namespace Unit06.Game.Casting
{
    /// <summary>
    /// <para>The Player in the game.</para>
    /// </summary>
    public class Enemy : Actor
    {
        //private string _message1 = "E";
        private int EnemyValue = 1;
        // private bool playerDetected;
        // private int sightDistance;
        public Enemy(string enemy, string messages, int vision)
        {
            int x = 0;
            int y = 0;

            Random rand = new Random();

            x = rand.Next(0,60) * 15;
            y = rand.Next(3,40) * 15;

            // create the player
            Cast cast = new Cast();

            SetText(messages);

            SetFontSize(Constants.FONT_SIZE);

            SetColor(Constants.RED);
            SetPosition(new Point(x, y));
            SetPlayerDetected(false);
            SetSightDistance(vision);
        }

        public int GetValue()
        {
            return EnemyValue;
        }

        public void SetValue(int ValueMaultiplier)
        {
            EnemyValue *= ValueMaultiplier;
        }
        
    }
}