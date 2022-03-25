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
            List<Actor>players = cast.GetActors("player");
            List<Actor>enemies = cast.GetActors("enemy");
            Point player1Position = players[0].GetPosition();
            Point player2Position = players[1].GetPosition();
            

            foreach (Actor enemy in enemies)
            {
                Point enemyPosition = enemy.GetPosition();

                if (enemyPosition.Equals(player1Position))
                {
                    Console.WriteLine("player1 gets hurt");
                }
                if (enemyPosition.Equals(player2Position))
                {
                    Console.WriteLine("player2 gets hurt");
                }

            }
            
        }
    }
}