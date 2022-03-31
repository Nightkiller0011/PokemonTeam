using Unit06.Game.Casting;
using Unit06.Game.Services;
using System.Collections.Generic;
using System;
namespace Unit06.Game.Scripting
{
    public class EnemyAIControlAction : Action
    {
        public EnemyAIControlAction()
        {

        }

        public void Execute(Cast cast, Script script)
        {
            List<Actor> enemies = cast.GetActors("enemy");
            List<Actor> players = cast.GetActors("player");

            foreach (Actor enemy in enemies)
            {
                // if (enemies.FindIndex(a => enemy)
            }
        }
    }
}