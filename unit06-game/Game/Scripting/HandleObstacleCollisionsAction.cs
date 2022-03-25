// using System;
// using System.Collections.Generic;
// using System.Data;
// using Unit06.Game.Casting;
// using Unit06.Game.Services;


// namespace Unit06.Game.Scripting
// {
//     public class HandleObstacleCollisionsAction : Action
//     {
//         //private AudioService audioService;
//         //private PhysicsService physicsService;
//         private Point direction = new Point(0, -1 * Constants.CELL_SIZE);
        
//         public HandleObstacleCollisionsAction ()//PhysicsService physicsService, AudioService audioService)
//         {
            
//             //this.physicsService = physicsService;
//             //this.audioService = audioService;
//         }

//         public void Execute(Cast cast, Script script) 
//         {
//             Actor players = cast.GetFirstActor("player");
//             List<Actor>obsticals = cast.GetActors("obstical");
//             Point playersPosition = players.GetPosition();
//             direction = new Point(0, 0);
//             bool collision = true;
            

//             foreach (Actor obstical in obsticals)
//             {
//                 Point obsticasPosition = obstical.GetPosition();

//                 if (obsticasPosition.Equals(playersPosition))
//                 {
                    

//                 }
//             }
//             collision = false;
        
//         }
//     }
// }