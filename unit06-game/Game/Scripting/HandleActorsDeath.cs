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
            Actor scores = cast.GetFirstActor("score");
           
    
            foreach (Actor player in players)
            {
                health = player.GetHealth();
                if (health <= 0)
                {
                    player.SetText("");
                }
            }   
               
            foreach(Actor enemy in enemies)
            {   
                health = enemy.GetHealth();

                if (health == 0)
                {
                    scores.SetScore(10);
                    scores.SetText("Score: " + scores.GetScore());
                    cast.RemoveActor("enemy",enemy);
                }
            }
        }
    }
}