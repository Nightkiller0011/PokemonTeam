using System;
using System.Collections.Generic;
using System.Data;
using Unit06.Game.Casting;
using Unit06.Game.Services;

namespace Unit06.Game.Scripting
{
    public class HandleEnemyPlayerCollisionsAction : Action
    {
        //private AudioService audioService;
        //private PhysicsService physicsService;
        
        public HandleEnemyPlayerCollisionsAction()//PhysicsService physicsService, AudioService audioService)
        {
            //this.physicsService = physicsService;
            //this.audioService = audioService;
        }

        public void Execute(Cast cast, Script script)
        {
            List<Actor> players = cast.GetActors("player");
            List<Actor> enemies = cast.GetActors("enemy");
            List<Actor> health = cast.GetActors("health");
            List<Actor> score = cast.GetActors("score");
            Point player1Position = players[0].GetPosition();
            Point player2Position = players[1].GetPosition();
            

            foreach (Actor enemy in enemies)
            {
                Point enemyPosition = enemy.GetPosition();

                if ((enemyPosition.Equals(player1Position)) && (players[0].GetText() != "") && (enemy.GetText() != ""))
                {
                    players[0].SetHealth(10);
                    health[0].SetHealth(10);
                    health[0].SetText("Player 1 Health: " + health[0].GetHealth());
                }
                if ((enemyPosition.Equals(player2Position)) && (players[1].GetText() != "") && (enemy.GetText() != ""))
                {
                    players[1].SetHealth(10);
                    health[1].SetHealth(10);
                    health[1].SetText("Player 2 Health: " + health[1].GetHealth());
                }

            }
            
        }
    }
}
