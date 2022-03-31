using System;
using System.Collections.Generic;
using System.Data;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class HandleActorsDeath : Action
    {
        int health;
        

        public HandleActorsDeath()
        {
            // health = 0;
        }

        public void RemoveActor(Cast cast, Script script)
        {
            
            
        }  
        public void Execute(Cast cast, Script script)
        {
            List<Actor> players = cast.GetActors("player");
            List<Actor> enemies = cast.GetActors("enemy");
           
    
            foreach (Actor player in players)
            {
                health = player.GetHealth();
                if (health == 0)
                {
                    // cast.RemoveActor("player",actor);
                    player.SetText("");
                }
            }   
               
            foreach(Actor enemy in enemies)
            {   
                health = enemy.GetHealth();

                if (health == 0)
                {
                    // cast.RemoveActor("enemies",enemy);
                    enemy.SetText("");
                }
            }
        }
    }
}