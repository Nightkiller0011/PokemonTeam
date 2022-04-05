namespace Unit06.Game.Casting
{
    
    /// <summary>
    /// <para>The Player in the game.</para>
    /// </summary>
    public class Instruction : Actor
    {
        /// <summary>
        /// Constructs a new instance of a Player.
        /// </summary>
        public Instruction()
        {
            // create the player
            Cast cast = new Cast();

            SetFontSize(Constants.FONT_SIZE);
            SetText("Welcome to the game! Press zero for instruction. Press spacebar to start game.");
            SetColor(Constants.WHITE);
            SetPosition(new Point(160, 300));
        }
    }
}
