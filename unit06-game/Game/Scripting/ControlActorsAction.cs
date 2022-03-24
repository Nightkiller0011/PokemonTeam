using Unit06.Game.Casting;
using Unit06.Game.Services;
using System.Collections.Generic;

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


        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public ControlActorsAction(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            // Set the directions as 0
            direction = new Point(0, 0);

            direction2 = new Point(0, 0);

            // Get players
            List<Actor> players = cast.GetActors("player");

            // Player 1's info
            Point player1Position = players[0].GetPosition();
            int player1X = player1Position.GetX();
            int player1Y = player1Position.GetY();

            // Player 2's info
            Point player2Position = players[1].GetPosition();
            int player2X = player2Position.GetX();
            int player2Y = player2Position.GetY();

            // player 1
            // left
            if (keyboardService.IsKeyDown("a"))
            {
                int player1NewX = player1X - Constants.CELL_SIZE;
                Point player1NewPosition = new Point(player1NewX, player1Y);
                if (player1NewPosition.Equals(player2Position))
                {
                    direction = new Point(0, 0);
                }
                else
                {
                    direction = new Point(-Constants.CELL_SIZE, 0);
                }
                players[0].setDirection("left");
            }

            // right
            if (keyboardService.IsKeyDown("d"))
            {
                int player1NewX = player1X + Constants.CELL_SIZE;
                Point player1NewPosition = new Point(player1NewX, player1Y);
                if (player1NewPosition.Equals(player2Position))
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
                if (player1NewPosition.Equals(player2Position))
                {
                    direction = new Point(0, 0);
                }
                else
                {
                    direction = new Point(0, -Constants.CELL_SIZE);
                }
                players[0].setDirection("up");
            }

            // down
            if (keyboardService.IsKeyDown("s"))
            {
                int player1NewY = player1Y + Constants.CELL_SIZE;
                Point player1NewPosition = new Point(player1X, player1NewY);
                if (player1NewPosition.Equals(player2Position))
                {
                    direction = new Point(0, 0);
                }
                else
                {
                    direction = new Point(0, Constants.CELL_SIZE);
                }
                players[0].setDirection("down");
            }
            
            // player 2
            // left
            if (keyboardService.IsKeyDown("j"))
            {
                int player2NewX = player2X - Constants.CELL_SIZE;
                Point player2NewPosition = new Point(player2NewX, player2Y);
                if (player2NewPosition.Equals(player1Position))
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
                if (player2NewPosition.Equals(player1Position))
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
                if (player2NewPosition.Equals(player1Position))
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
                if (player2NewPosition.Equals(player1Position))
                {
                    direction2 = new Point(0, 0);
                }
                else
                {
                    direction2 = new Point(0, Constants.CELL_SIZE);
                }
                players[1].setDirection("down");
            }

            if (keyboardService.IsKeyDown("e"))
            {
                players[0].attack();
            }

            if (keyboardService.IsKeyDown("o"))
            {
                players[1].attack();
            }

            // Snake snake = (Snake)cast.GetFirstActor("snake");
            // Snake snake1 = (Snake) snakes[0];
            // Snake snake2 = (Snake) snakes[1];
            // snake1.TurnHead(direction);
            // snake2.TurnHead(direction2);
            players[0].SetVelocity(direction);
            players[1].SetVelocity(direction2);
        }
    }
}