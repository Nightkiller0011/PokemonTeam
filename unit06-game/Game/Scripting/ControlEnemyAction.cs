using Unit06.Game.Casting;
using Unit06.Game.Services;
using System.Collections.Generic;
using System;
namespace Unit06.Game.Scripting
{
    /// <summary>
    /// <para>An input action that controls the snake.</para>
    /// <para>
    /// The responsibility of ControlActorsAction is to get the direction and move the snake's head.
    /// </para>
    /// </summary>
    public class ControlEnemyAction : Action
    {
        
        public ControlEnemyAction()
        {
        }

        public void BasicMovement(int direction, int movement)
        {

        }

        public void FollowMovement()
        {
            Console.WriteLine("Following a player");

        }

        public void EnemyCollision()
        {

        }

        public async void Execute(Cast cast, Script script)
        {
            //if enemy doesnt detect player ther do BasicMovement else do Follow Movements
            List<Actor> enemies = cast.GetActors("enemy");
            foreach (Actor enemy in enemies)
            {
                if (enemy.GetPlayerDetected())
                {
                    FollowMovement();
                }
                // else
                // {
                //     BasicMovement();
                // }
            }
        }
    }
  
}
