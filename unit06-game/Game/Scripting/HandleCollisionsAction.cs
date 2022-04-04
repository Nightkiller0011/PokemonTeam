using System;
using System.Collections.Generic;
using System.Data;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    /// <summary>
    /// <para>An update action that handles interactions between the actors.</para>
    /// <para>
    /// The responsibility of HandleCollisionsAction is to handle the situation when the snake 
    /// collides with the food, or the snake collides with its segments, or the game is over.
    /// </para>
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        private bool isGameOver = false;

        /// <summary>
        /// Constructs a new instance of HandleCollisionsAction.
        /// </summary>
        public HandleCollisionsAction()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            if (isGameOver == false)
            {
                HandlePlayerhealth(cast);
                HandleGameOver(cast);
            }
        }

        public void HandlePlayerhealth(Cast cast)
        {
            List<Actor>players = cast.GetActors("player");
            if (players[0].GetHealth() <= 0 || players[1].GetHealth() <= 0)
            {
                isGameOver = true;
            }
        }

        

        private void HandleGameOver(Cast cast)
        {
            List<Actor> score = cast.GetActors("score");
            if (isGameOver == true)
            {
            
                 int x = Constants.MAX_X / 2;
                 int y = Constants.MAX_Y / 2;
                 Point position = new Point(x, y);

                 Actor message = new Actor();
                 message.SetText("Game Over! Your final score is ");
                 message.SetPosition(position);
                 cast.AddActor("messages", message);

            }
        }

    }
}