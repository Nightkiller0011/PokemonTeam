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
        private string image = "";
        private int fontSize = 15;
        private Color color = Constants.WHITE;
        private Point position = new Point(0, 0);
        private Point velocity = new Point(0, 0);
        string direction = "left";
        string fightClass = "";
        private int health = 100;
        private int score = 0;
        private int sightDistance;
        private bool playerDetected;

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
            direction = directionIn;
        }

        // This function returns directional facing.
        public string getDirection()
        {
            return direction;
        }

        // This function sets Class type
        public void setFightClass(string type)
        {
            fightClass = type;
        }

        // This function gets Class Tye
        public string getFightClass()
        {
            return fightClass;
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
        public int GetScore()
        {
            return score;
        }
        public void SetScore(int v)
        {
            score += v;
        }

        public void SetSightDistance(int number)
        {
            if (number <= 0)
            {
                number = 1;
            }
            sightDistance = number * Constants.CELL_SIZE;
        }

        public int GetSightDistance()
        {
            return sightDistance;
        }
        public void SetPlayerDetected(bool thing)
        {
            playerDetected = thing;
        }
        public bool GetPlayerDetected()
        {
            return playerDetected;
        }

        public void SetImage(string pic)
        {
            image = pic;
        }
        public string GetImage()
        {
            return image;
        }
    }
}