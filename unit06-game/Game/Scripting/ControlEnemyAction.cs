using Unit06.Game.Casting;
using Unit06.Game.Services;
using System.Collections.Generic;
using System;
namespace Unit06.Game.Scripting
{
    /// <summary>
    /// <para>An input action that controls the snake.</para>
    /// <para>
    /// The responsibility of ControlActorsAction is to get the direction and move the snake's head.
    /// </para>
    /// </summary>
    public class ControlEnemyAction : Action
    {
        private Random rand = new Random();
        public ControlEnemyAction()
        {
        }

        public async void BasicMovement(Actor enemy)
        {
            //Direction is where the enemy is facing
            //steps is how far it goes
            Point enenyPoint = enemy.GetPosition();
            int direction = rand.Next(0,3);
            int steps = rand.Next(1,10);
            
                //Straight
                if (direction == 0)
                {
                    Point y = new Point(0,5);

                    enenyPoint.Add(y);
                    enemy.SetVelocity(y);
                }
                //Left
                else if ( direction == 1)
                {
                    Point y = new Point(-5,0);

                    enenyPoint.Add(y);
                    enemy.SetVelocity(y);
                }
                //Right
                else if (direction == 2)
                {
                    Point y = new Point(5,0);

                    enenyPoint.Add(y);
                    enemy.SetVelocity(y);
                }
                //Back
                else if( direction == 3)
                {
                    Point y = new Point(0,-5);

                    enenyPoint.Add(y);
                    enemy.SetVelocity(y);
                }
            
        }

        public void FollowMovement(List<Point> playerPositions, Point enemyPosition, Actor enemy, Cast cast)
        {
            /* first step is minus x and y from players position to enemy positions. So playerX - enemyX. 
            If result number is +x +y than enemy moves down right.
            If result is 0x +y than enemy moves down
            If result is +x 0y than enemy moves right
            If result is 0x 0y than enemy don't move
            If result is -x -y than enemy move up left
            If result is 0x -y than enemy move up
            If result is -x 0y than enemy move left
            If result is -x +y than enemy move down left
            If result is +x -y than enemy move up right */

            //Enemy Position
            int enemyX = enemyPosition.GetX();
            int enemyY = enemyPosition.GetY();

            //Both player 1 and 2 positions
            int player1X = playerPositions[0].GetX();
            int player1Y = playerPositions[0].GetY();
            int player2X = playerPositions[1].GetX();
            int player2Y = playerPositions[1].GetY();

            //Both player 1 and 2 texts
            List<Actor> players = cast.GetActors("player");
            string player1Text = players[0].GetText();
            string player2Text = players[1].GetText();

            //get position radius from player 1
            int enemyMovePlayer1X = player1X - enemyX;
            int enemyMovePlayer1Y = player1Y - enemyY;

            //get position radius from player 2
            int enemyMovePlayer2X = player2X - enemyX;
            int enemyMovePlayer2Y = player2Y - enemyY;

            // See which player closer
            int enemyToPlayer1 = System.Math.Abs(enemyMovePlayer1X) + System.Math.Abs(enemyMovePlayer1Y);
            int enemyToPlayer2 = System.Math.Abs(enemyMovePlayer2X) + System.Math.Abs(enemyMovePlayer2Y);

            //Check whos closer
            /*
               // +x +y = right down
               // 0x +y = down
               // +x 0y = right
               // 0x 0y = nowhere
               // -x -y = left up
               // 0x -y = up
               // -x 0y = left
               // +x -y = right up
               // -x +y = left down

            */
            if ((enemyToPlayer1 <= enemyToPlayer2) && (player1Text != "")) 
            {
                //Enemy movement towards player 1
                if (enemyMovePlayer1X > 0 && enemyMovePlayer1Y > 0)
                {
                    // +x +y = right down
                    Point direction = new Point(5,5);
                    enemy.SetVelocity(direction);

                }
                else if (enemyMovePlayer1X == 0 && enemyMovePlayer1Y > 0)
                {
                    // 0x +y = down
                    Point direction = new Point(0,5);
                    enemy.SetVelocity(direction);

                }
                else if (enemyMovePlayer1X > 0 && enemyMovePlayer1Y == 0)
                {
                    // +x 0y = right
                    Point direction = new Point(5,0);
                    enemy.SetVelocity(direction);

                }
                else if (enemyMovePlayer1X < 0 && enemyMovePlayer1Y < 0)
                {
                    // -x -y = left up
                    Point direction = new Point(-5,-5);
                    enemy.SetVelocity(direction);

                }
                else if (enemyMovePlayer1X == 0 && enemyMovePlayer1Y < 0)
                {
                    // 0x -y = up
                    Point direction = new Point(0,-5);
                    enemy.SetVelocity(direction);

                }
                else if (enemyMovePlayer1X < 0 && enemyMovePlayer1Y == 0)
                {
                    // -x 0y = left
                    Point direction = new Point(-5,0);
                    enemy.SetVelocity(direction);

                }
                else if (enemyMovePlayer1X > 0 && enemyMovePlayer1Y < 0)
                {
                    // +x -y = right up
                    Point direction = new Point(5,-5);
                    enemy.SetVelocity(direction);

                }
                else if (enemyMovePlayer1X < 0 && enemyMovePlayer1Y > 0)
                {
                    // -x +y = left down
                    Point direction = new Point(-5,5);
                    enemy.SetVelocity(direction);

                }
                else
                {
                    // 0x 0y = nowhere
                    Point direction = new Point(0,0);
                    enemy.SetVelocity(direction);

                }
            }
            else if ((enemyToPlayer2 <= enemyToPlayer1) && (player2Text != ""))
            {
                //Enemy movement towards player 2
                if (enemyMovePlayer2X > 0 && enemyMovePlayer2Y > 0)
                {
                    // +x +y = right down
                    Point direction = new Point(5,5);
                    enemy.SetVelocity(direction);
                }
                else if (enemyMovePlayer2X == 0 && enemyMovePlayer2Y > 0)
                {
                    // 0x +y = down
                    Point direction = new Point(0,5);
                    enemy.SetVelocity(direction);

                }
                else if (enemyMovePlayer2X > 0 && enemyMovePlayer2Y == 0)
                {
                    // +x 0y = right
                    Point direction = new Point(5,0);
                    enemy.SetVelocity(direction);

                }
                else if (enemyMovePlayer2X < 0 && enemyMovePlayer2Y < 0)
                {
                    // -x -y = left up
                    Point direction = new Point(-5,-5);
                    enemy.SetVelocity(direction);

                }
                else if (enemyMovePlayer2X == 0 && enemyMovePlayer2Y < 0)
                {
                    // 0x -y = up
                    Point direction = new Point(0,-5);
                    enemy.SetVelocity(direction);

                }
                else if (enemyMovePlayer2X < 0 && enemyMovePlayer2Y == 0)
                {
                    // -x 0y = left
                    Point direction = new Point(-5,0);
                    enemy.SetVelocity(direction);

                }
                else if (enemyMovePlayer2X > 0 && enemyMovePlayer2Y < 0)
                {
                    // +x -y = right up
                    Point direction = new Point(5,-5);
                    enemy.SetVelocity(direction);

                }
                else if (enemyMovePlayer2X < 0 && enemyMovePlayer2Y > 0)
                {
                    // -x +y = left down
                    Point direction = new Point(-5,5);
                    enemy.SetVelocity(direction);
                }
                else
                {
                    // 0x 0y = nowhere
                    Point direction = new Point(0,0);
                    enemy.SetVelocity(direction);
                    
                }
            }

            // Console.WriteLine("Following a player");

        }

        public void EnemyCollision()
        {

        }

        public async void Execute(Cast cast, Script script)
        {
            //if enemy doesnt detect player ther do BasicMovement else do Follow Movements
            List<Actor> enemies = cast.GetActors("enemy");
            List<Actor> players = cast.GetActors("player");
            List<Point> playersPositions = new List<Point>(2){players[0].GetPosition(), players[1].GetPosition()};
            foreach (Actor enemy in enemies)
            {
                if (enemy.GetPlayerDetected())
                {
                    Point enemyPos = enemy.GetPosition();
                    FollowMovement(playersPositions, enemyPos, enemy, cast);
                }
                else
                {
                    BasicMovement(enemy);
                }

            }
        }
    }
}
  

