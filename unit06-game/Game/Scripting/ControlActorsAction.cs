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
    public class ControlActorsAction : Action
    {
        private KeyboardService keyboardService;
        private Point direction = new Point(0, -1 * Constants.CELL_SIZE);
        private Point direction2 = new Point(0, -1 * Constants.CELL_SIZE);

        private bool ItHit = false;


        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public ControlActorsAction(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        /// <inheritdoc/>
        public async void Execute(Cast cast, Script script)
        {
            // Set the directions as 0
            direction = new Point(0, 0);

            direction2 = new Point(0, 0);

            // Get players

            List<Actor> players = cast.GetActors("player");
            List<Actor> obsticals = cast.GetActors("obstical");
            List<Actor> health = cast.GetActors("health");
            List<Actor> score = cast.GetActors("score");
            
            // Player 1's info
            Point player1Position = players[0].GetPosition();
            int player1X = player1Position.GetX();
            int player1Y = player1Position.GetY();

            // Player 2's info
            Point player2Position = players[1].GetPosition();
            int player2X = player2Position.GetX();
            int player2Y = player2Position.GetY();

            // Obstacle1's info 
            Point obstacle1Position = obsticals[0].GetPosition();

            // obstacle2's info 
            Point obstacle2Position = obsticals[1].GetPosition();

            // obstacle3's info
            Point obstacle3Position = obsticals[2].GetPosition();

            // Health player 1 info
            Point Health1Position = health[0].GetPosition();

            // Health player 2 info
            Point Health2Position = health[1].GetPosition();

            // Score Position
            Point ScorePosition = score[0].GetPosition();

            

                if (keyboardService.IsKeyDown("a"))
                {
                    int player1NewX = player1X - Constants.CELL_SIZE;
                    Point player1NewPosition = new Point(player1NewX, player1Y);
                    if (player1NewPosition.Equals(player2Position) || player1NewPosition.Equals(obstacle1Position) 
                    || player1NewPosition.Equals(obstacle2Position) || player1NewPosition.Equals(obstacle3Position))
                    {
                        direction = new Point(0, 0);
                    }
                    else
                    {
                        direction = new Point(-Constants.CELL_SIZE, 0);
                        Console.WriteLine(players[0].GetPosition());
                    }
                    players[0].setDirection("left");
                }

                // right
                if (keyboardService.IsKeyDown("d"))
                {
                    int player1NewX = player1X + Constants.CELL_SIZE;
                    Point player1NewPosition = new Point(player1NewX, player1Y);
                    if (player1NewPosition.Equals(player2Position)|| player1NewPosition.Equals(obstacle1Position)
                     || player1NewPosition.Equals(obstacle2Position) || player1NewPosition.Equals(obstacle3Position))
                    {
                        direction = new Point(0, 0);
                    }
                    else
                    {
                        direction = new Point(Constants.CELL_SIZE, 0);
                    }
                    players[0].setDirection("right");
                }

                // up
                if (keyboardService.IsKeyDown("w"))
                {
                    int player1NewY = player1Y - Constants.CELL_SIZE;
                    Point player1NewPosition = new Point(player1X, player1NewY);
                    if (player1NewPosition.Equals(player2Position)|| player1NewPosition.Equals(obstacle1Position)
                     || player1NewPosition.Equals(obstacle2Position) || player1NewPosition.Equals(obstacle3Position)
                     || player1Y <= 15)
                    {
                        direction = new Point(0, 0);
                    }
                    else
                    {
                        direction = new Point(0, -Constants.CELL_SIZE);
                        Console.WriteLine(players[0].GetPosition());
                        Console.WriteLine(player1X + "," + player1Y);
                    }
                    players[0].setDirection("up");
                }

                // down
                if (keyboardService.IsKeyDown("s"))
                {
                    int player1NewY = player1Y + Constants.CELL_SIZE;
                    Point player1NewPosition = new Point(player1X, player1NewY);
                    if (player1NewPosition.Equals(player2Position)|| player1NewPosition.Equals(obstacle1Position) 
                    || player1NewPosition.Equals(obstacle2Position) || player1NewPosition.Equals(obstacle3Position)
                    || player1Y == Constants.MAX_Y-15)
                    {
                        direction = new Point(0, 0);
                    }
                    else
                    {
                        direction = new Point(0, Constants.CELL_SIZE);
                    }
                    players[0].setDirection("down");
                }

                // left
                if (keyboardService.IsKeyDown("j"))
                {
                    int player2NewX = player2X - Constants.CELL_SIZE;
                    Point player2NewPosition = new Point(player2NewX, player2Y);
                    if (player2NewPosition.Equals(player1Position)|| player2NewPosition.Equals(obstacle1Position) 
                    || player2NewPosition.Equals(obstacle2Position) || player2NewPosition.Equals(obstacle3Position))
                    {
                        direction2 = new Point(0, 0);
                    }
                    else
                    {
                        direction2 = new Point(-Constants.CELL_SIZE, 0);
                    }
                    players[1].setDirection("left");
                }

                // right
                if (keyboardService.IsKeyDown("l"))
                {
                    int player2NewX = player2X + Constants.CELL_SIZE;
                    Point player2NewPosition = new Point(player2NewX, player2Y);
                    if (player2NewPosition.Equals(player1Position)|| player2NewPosition.Equals(obstacle1Position) 
                    || player2NewPosition.Equals(obstacle2Position) || player2NewPosition.Equals(obstacle3Position))
                    {
                        direction2 = new Point(0, 0);
                    }
                    else
                    {
                        direction2 = new Point(Constants.CELL_SIZE, 0);
                    }
                    players[1].setDirection("right");
                }

                // up
                if (keyboardService.IsKeyDown("i"))
                {
                    int player2NewY = player2Y - Constants.CELL_SIZE;
                    Point player2NewPosition = new Point(player2X, player2NewY);
                    if (player2NewPosition.Equals(player1Position)|| player2NewPosition.Equals(obstacle1Position) 
                    || player2NewPosition.Equals(obstacle2Position) || player2NewPosition.Equals(obstacle3Position)
                    || player2Y == 15)
                    {
                        direction2 = new Point(0, 0);
                    }
                    else
                    {
                        direction2 = new Point(0, -Constants.CELL_SIZE);
                    }
                    players[1].setDirection("up");
                }

                // down
                if (keyboardService.IsKeyDown("k"))
                {
                    int player2NewY = player2Y + Constants.CELL_SIZE;
                    Point player2NewPosition = new Point(player2X, player2NewY);
                    if (player2NewPosition.Equals(player1Position)|| player2NewPosition.Equals(obstacle1Position) 
                    || player2NewPosition.Equals(obstacle2Position) || player2NewPosition.Equals(obstacle3Position)
                    || player2Y == 600-15)
                    {
                        direction2 = new Point(0, 0);
                    }
                    else
                    {
                        direction2 = new Point(0, Constants.CELL_SIZE);
                    }
                    players[1].setDirection("down");
                }

            players[0].SetVelocity(direction);
            players[1].SetVelocity(direction2);
        }
    }
}