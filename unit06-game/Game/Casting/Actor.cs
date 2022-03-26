using System;


namespace Unit06.Game.Casting
{
    /// <summary>
    /// <para>A thing that participates in the game.</para>
    /// <para>
    /// The responsibility of Actor is to keep track of its appearance, position and velocity in 2d 
    /// space.
    /// </para>
    /// </summary>
    public class Actor
    {
        private string text = "";
        private int fontSize = 15;
        private Color color = Constants.WHITE;
        private Point position = new Point(0, 0);
        private Point velocity = new Point(0, 0);
        string direction = "up";
        string fightClass = "knight";
        private int health = 100;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Actor()
        {
        }

        /// <summary>
        /// Gets the actor's color.
        /// </summary>
        /// <returns>The color.</returns>
        public Color GetColor()
        {
            return color;
        }

        /// <summary>
        /// Gets the actor's font size.
        /// </summary>
        /// <returns>The font size.</returns>
        public int GetFontSize()
        {
            return fontSize;
        }

        /// <summary>
        /// Gets the actor's position.
        /// </summary>
        /// <returns>The position.</returns>
        public Point GetPosition()
        {
            return position;
        }

        /// <summary>
        /// Gets the actor's text.
        /// </summary>
        /// <returns>The text.</returns>
        public string GetText()
        {
            return text;
        }

        /// <summary>
        /// Gets the actor's current velocity.
        /// </summary>
        /// <returns>The velocity.</returns>
        public Point GetVelocity()
        {
            return velocity;
        }

        /// <summary>
        /// Moves the actor to its next position according to its velocity. Will wrap the position 
        /// from one side of the screen to the other when it reaches the maximum x and y 
        /// values.
        /// </summary>
        public virtual void MoveNext()
        {
            int x = ((position.GetX() + velocity.GetX()) + Constants.MAX_X) % Constants.MAX_X;
            int y = ((position.GetY() + velocity.GetY()) + Constants.MAX_Y) % Constants.MAX_Y;
            position = new Point(x, y);
        }

        /// <summary>
        /// Sets the actor's color to the given value.
        /// </summary>
        /// <param name="color">The given color.</param>
        /// <exception cref="ArgumentException">When color is null.</exception>
        public void SetColor(Color color)
        {
            if (color == null)
            {
                throw new ArgumentException("color can't be null");
            }
            this.color = color;
        }

        /// <summary>
        /// Sets the actor's font size to the given value.
        /// </summary>
        /// <param name="fontSize">The given font size.</param>
        /// <exception cref="ArgumentException">
        /// When font size is less than or equal to zero.
        /// </exception>
        public void SetFontSize(int fontSize)
        {
            if (fontSize <= 0)
            {
                throw new ArgumentException("fontSize must be greater than zero");
            }
            this.fontSize = fontSize;
        }

        /// <summary>
        /// Sets the actor's position to the given value.
        /// </summary>
        /// <param name="position">The given position.</param>
        /// <exception cref="ArgumentException">When position is null.</exception>
        public void SetPosition(Point position)
        {
            if (position == null)
            {
                throw new ArgumentException("position can't be null");
            }
            this.position = position;
        }

        /// <summary>
        /// Sets the actor's text to the given value.
        /// </summary>
        /// <param name="text">The given text.</param>
        /// <exception cref="ArgumentException">When text is null.</exception>
        public void SetText(string text)
        {
            if (text == null)
            {
                throw new ArgumentException("text can't be null");
            }
            this.text = text;
        }

        /// <summary>
        /// Sets the actor's velocity to the given value.
        /// </summary>
        /// <param name="velocity">The given velocity.</param>
        /// <exception cref="ArgumentException">When velocity is null.</exception>
        public void SetVelocity(Point velocity)
        {
            if (velocity == null)
            {
                throw new ArgumentException("velocity can't be null");
            }
            this.velocity = velocity;
        }


        // This function sets directional facing.

        public void setDirection(string directionIn)
        {
            directionIn = direction;
        }

        // This function returns directional facing.
        public string getDirection()
        {
            return direction;
        }

        // This function sets Class type
        public void setFightClass(string type)
        {
            type = fightClass;
        }

        // This function gets Class Tye
        public string getFightClass()
        {
            return fightClass;
        }

        //This function has the actor attack

        public void attack()
        {
            Point currentSpot = GetPosition();
            int currentX = currentSpot.GetX();
            int currentY = currentSpot.GetY();
            string facing = getDirection();
            Point attackSpot1 = new Point(0,0);
            Point attackSpot2 = new Point(0,0);
            Point attackSpot3 = new Point(0,0);
            Point attackSpot4 = new Point(0,0);
            Point attackSpot5 = new Point(0,0);
            Point attackSpot6 = new Point(0,0);
            
            if (fightClass == "knight")
            {
                if (facing == "left")
                {
                    attackSpot1 = new Point(currentX - Constants.CELL_SIZE, currentY);
                    attackSpot2 = new Point(currentX - (2*Constants.CELL_SIZE), currentY);
                    attackSpot3 = new Point(currentX - Constants.CELL_SIZE, currentY + Constants.CELL_SIZE);
                    attackSpot4 = new Point(currentX - (2*Constants.CELL_SIZE), currentY + Constants.CELL_SIZE);
                    attackSpot5 = new Point(currentX - Constants.CELL_SIZE, currentY - Constants.CELL_SIZE);
                    attackSpot6 = new Point(currentX - (2*Constants.CELL_SIZE), currentY - Constants.CELL_SIZE);
                }
                if (facing == "right")
                {
                    attackSpot1 = new Point(currentX + Constants.CELL_SIZE, currentY);
                    attackSpot2 = new Point(currentX + (2*Constants.CELL_SIZE), currentY);
                    attackSpot3 = new Point(currentX + Constants.CELL_SIZE, currentY + Constants.CELL_SIZE);
                    attackSpot4 = new Point(currentX + (2*Constants.CELL_SIZE), currentY + Constants.CELL_SIZE);
                    attackSpot5 = new Point(currentX + Constants.CELL_SIZE, currentY - Constants.CELL_SIZE);
                    attackSpot6 = new Point(currentX + (2*Constants.CELL_SIZE), currentY - Constants.CELL_SIZE);
                }
                if (facing == "up")
                {
                    attackSpot1 = new Point(currentX, currentY - Constants.CELL_SIZE);
                    attackSpot2 = new Point(currentX, currentY  - (2*Constants.CELL_SIZE));
                    attackSpot3 = new Point(currentX + Constants.CELL_SIZE, currentY - Constants.CELL_SIZE);
                    attackSpot4 = new Point(currentX + Constants.CELL_SIZE, currentY - (2*Constants.CELL_SIZE));
                    attackSpot5 = new Point(currentX - Constants.CELL_SIZE, currentY - Constants.CELL_SIZE);
                    attackSpot6 = new Point(currentX - Constants.CELL_SIZE, currentY - (2*Constants.CELL_SIZE));
                }
                if (facing == "down")
                {
                    attackSpot1 = new Point(currentX, currentY + Constants.CELL_SIZE);
                    attackSpot2 = new Point(currentX, currentY  + (2*Constants.CELL_SIZE));
                    attackSpot3 = new Point(currentX + Constants.CELL_SIZE, currentY + Constants.CELL_SIZE);
                    attackSpot4 = new Point(currentX + Constants.CELL_SIZE, currentY + (2*Constants.CELL_SIZE));
                    attackSpot5 = new Point(currentX - Constants.CELL_SIZE, currentY + Constants.CELL_SIZE);
                    attackSpot6 = new Point(currentX - Constants.CELL_SIZE, currentY + (2*Constants.CELL_SIZE));                
                }
            }
            else if (fightClass == "archer")
            {
                if (facing == "left")
                {
                    attackSpot1 = new Point(currentX - Constants.CELL_SIZE, currentY);
                    attackSpot2 = new Point(currentX - (2*Constants.CELL_SIZE), currentY);
                    attackSpot3 = new Point(currentX - (3*Constants.CELL_SIZE), currentY);
                    attackSpot4 = new Point(currentX - (4*Constants.CELL_SIZE), currentY);
                    attackSpot5 = new Point(currentX - (5*Constants.CELL_SIZE), currentY);
                    attackSpot6 = new Point(currentX - (6*Constants.CELL_SIZE), currentY);
                }
                if (facing == "right")
                {
                    attackSpot1 = new Point(currentX + Constants.CELL_SIZE, currentY);
                    attackSpot2 = new Point(currentX + (2*Constants.CELL_SIZE), currentY);
                    attackSpot3 = new Point(currentX + (3*Constants.CELL_SIZE), currentY);
                    attackSpot4 = new Point(currentX + (4*Constants.CELL_SIZE), currentY);
                    attackSpot5 = new Point(currentX + (5*Constants.CELL_SIZE), currentY);
                    attackSpot6 = new Point(currentX + (6*Constants.CELL_SIZE), currentY);                
                }
                if (facing == "up")
                {
                    attackSpot1 = new Point(currentX, currentY - Constants.CELL_SIZE);
                    attackSpot2 = new Point(currentX, currentY - (2*Constants.CELL_SIZE));
                    attackSpot3 = new Point(currentX, currentY - (3*Constants.CELL_SIZE));
                    attackSpot4 = new Point(currentX, currentY - (4*Constants.CELL_SIZE));
                    attackSpot5 = new Point(currentX, currentY - (5*Constants.CELL_SIZE));
                    attackSpot6 = new Point(currentX, currentY - (6*Constants.CELL_SIZE));                
                }
                if (facing == "down")
                {
                    attackSpot1 = new Point(currentX, currentY + Constants.CELL_SIZE);
                    attackSpot2 = new Point(currentX, currentY + (2*Constants.CELL_SIZE));
                    attackSpot3 = new Point(currentX, currentY + (3*Constants.CELL_SIZE));
                    attackSpot4 = new Point(currentX, currentY + (4*Constants.CELL_SIZE));
                    attackSpot5 = new Point(currentX, currentY + (5*Constants.CELL_SIZE));
                    attackSpot6 = new Point(currentX, currentY + (6*Constants.CELL_SIZE));
                }
            }

            
        }
        // Health that can be used for both enemys and the player
        public int GetHealth()
        {
            return health;
        }

        public void SetHealth(int damage)
        {
            health -= damage;
        }
            
    }
}