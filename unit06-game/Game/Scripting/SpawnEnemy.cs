using System;
using System.Collections.Generic;
using System.Data;
using Unit06.Game.Casting;
using Unit06.Game.Services;

namespace Unit06.Game.Scripting
{
    public class SpawnEnemy : Action
    {
        public void Execute(Cast cast, Script script)
        {
            List<Actor> enemies = cast.GetActors("enemy");
            if (enemies.Count < Constants.enemyCap)
            {
                for (int i = enemies.Count; i < Constants.enemyCap; i++)
                {
                    if (i% 3 == 0)
                    {
                        cast.AddActor("enemy", new Enemy("zombie", "Z", 6));
                    }
                    else if (i%3 == 1)
                    {
                        cast.AddActor("enemy", new Enemy("skeleton", "S", 7));
                    }
                    else if (i%3 == 2)
                    {
                        cast.AddActor("enemy", new Enemy("minator", "M", 8));
                    }
                }
            }
        }
    }
}