using System;
using System.Collections.Generic;
using System.Data;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class HandleActorsDeath 
    {
        int health;
        

        public HandleActorsDeath()
        {
            health = 0;
        }

        public void RemoveActor(Cast cast, Script script)
        {
            List<Actor> players = cast.GetActors("player");
            List<Actor> enemies = cast.GetActors("enemy");
           
           
            
            foreach (Actor actor in players )
            {
                actor.GetHealth();
                

                foreach(Actor enemy in enemies)
                {   
                    enemy.GetHealth();

                    if ( health == 0)
                    {
                        cast.RemoveActor("player",actor);
                        cast.RemoveActor("enemies",enemy);
                    }
                }
            }

            
        }  
        public void Execute(Cast cast, Script script)
        {
           
        }
        
    }
}