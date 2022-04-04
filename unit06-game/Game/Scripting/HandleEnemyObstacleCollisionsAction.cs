using Unit06.Game.Casting;
using Unit06.Game.Services;
using System.Collections.Generic;
using System;
namespace Unit06.Game.Scripting
{
    public class HandleEnemyOstacleCollisionsAction : Action
    {
        public HandleEnemyOstacleCollisionsAction()
        {

        }

        public void Execute(Cast cast, Script script)
        {
            List<Actor> enemies = cast.GetActors("enemy");
            List<Actor> obstacles = cast.GetActors("obstical");

            foreach (Actor enemy in enemies)
            {
                Point enemyPosition = enemy.GetPosition();
                int enemyX = enemyPosition.GetX();
                int enemyY = enemyPosition.GetY();

                Point enemyVelocity = enemy.GetVelocity();
                int enemyXVelocity = enemyVelocity.GetX();
                int enemyYVelovity = enemyVelocity.GetY();

                Point enemyNewPosition = new Point(enemyX + enemyXVelocity, enemyY + enemyYVelovity);

                foreach ( Actor obstacle in obstacles)
                {
                    Point obstaclePosition = obstacle.GetPosition();

                    if (enemyNewPosition.Equals(obstaclePosition))
                    {
                        enemy.SetVelocity(new Point(0, 0));
                    }
                }
            }
        }
    }
}

