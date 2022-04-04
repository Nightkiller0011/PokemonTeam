using Unit06.Game.Casting;
using Unit06.Game.Services;
using System.Collections.Generic;
using System;
namespace Unit06.Game.Scripting
{
    public class HandleEnemiesVisionsAction : Action
    {
        public HandleEnemiesVisionsAction()
        {

        }

        public async void Execute(Cast cast, Script script)
        {
            List<Actor> enemies = cast.GetActors("enemy");
            List<Actor> players = cast.GetActors("player");

            foreach (Actor enemy in enemies)
            {
                int enemyX = enemy.GetPosition().GetX();
                int enemyY = enemy.GetPosition().GetY();

                foreach (Actor player in players)
                {
                    int playerX = player.GetPosition().GetX();
                    int playerY = player.GetPosition().GetY();
                    if (((enemyX - enemy.GetSightDistance() < playerX) && (playerX < enemyX + enemy.GetSightDistance())) && ((enemyY - enemy.GetSightDistance() < playerY) && (playerY < enemyY + enemy.GetSightDistance())))
                    {
                        if (player.GetText() != "")
                        {
                            enemy.SetPlayerDetected(true);
                        }
                    }
                }
            }
        }
    }
}

