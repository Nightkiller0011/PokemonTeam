using System.Collections.Generic;
using System.Reflection.Metadata;
using Raylib_cs;
using Unit06.Game.Casting;


namespace Unit06.Game.Services
{
    /// <summary>
    /// <para>Outputs the game state.</para>
    /// <para>
    /// The responsibility of the class of objects is to draw the game state on the screen. 
    /// </para>
    /// </summary>
    public class VideoService
    {
        private bool debug = false;

        /// <summary>
        /// Constructs a new instance of KeyboardService using the given cell size.
        /// </summary>
        /// <param name="cellSize">The cell size (in pixels).</param>
        public VideoService(bool debug)
        {
            this.debug = debug;
        }

        /// <summary>
        /// Closes the window and releases all resources.
        /// </summary>
        public void CloseWindow()
        {
            Raylib.CloseWindow();
        }

        /// <summary>
        /// Clears the buffer in preparation for the next rendering. This method should be called at
        /// the beginning of the game's output phase.
        /// </summary>
        public void ClearBuffer()
        {
            Raylib.BeginDrawing();
            //Raylib.ClearBackground("Assats/Assets/BackGround.png");
            Image BackGround = Raylib.LoadImage("Assats/Assets/BackGround3.png");
            Texture2D texture = Raylib.LoadTextureFromImage(BackGround);
            Raylib.UnloadImage(BackGround);
            Raylib.DrawTexture(texture,0,0,Raylib_cs.Color.WHITE);
            if (debug)
            {
                DrawGrid();
            }
        }

        /// <summary>
        /// Draws the given actor's text on the screen.
        /// </summary>
        /// <param name="actor">The actor to draw.</param>
        public void DrawActor(Actor actor)
        {
            int x = actor.GetPosition().GetX();
            int y = actor.GetPosition().GetY();
            Casting.Color c = actor.GetColor();
            Raylib_cs.Color color = ToRaylibColor(c);
            string file = actor.GetImage();
            if(file != "" && actor.GetHealth() > 0)
            {
                Image pic = Raylib.LoadImage(file);
                Texture2D img = Raylib.LoadTextureFromImage(pic);
                Raylib.UnloadImage(pic);
                Raylib.DrawTexture(img,x,y,Raylib_cs.Color.WHITE);
            }
            
            else
            {
                string text = actor.GetText();
                int fontSize = actor.GetFontSize();
                Raylib.DrawText(text, x, y, fontSize, color);
            }
        }

        /// <summary>
        /// Draws the given list of actors on the screen.
        /// </summary>
        /// <param name="actors">The list of actors to draw.</param>
        public void DrawActors(List<Actor> actors)
        {
            foreach (Actor actor in actors)
            {
                DrawActor(actor);
            }
        }
        
        /// <summary>
        /// Copies the buffer contents to the screen. This method should be called at the end of
        /// the game's output phase.
        /// </summary>
        public void FlushBuffer()
        {
            Raylib.EndDrawing();
        }

        /// <summary>
        /// Whether or not the window is still open.
        /// </summary>
        /// <returns>True if the window is open; false if otherwise.</returns>
        public bool IsWindowOpen()
        {
            return !Raylib.WindowShouldClose();
        }

        /// <summary>
        /// Opens a new window with the provided title.
        /// </summary>
        public void OpenWindow()
        {
            Raylib.InitWindow(Constants.MAX_X, Constants.MAX_Y, Constants.CAPTION);
            Raylib.SetTargetFPS(Constants.FRAME_RATE);
        }

        /// <summary>
        /// Draws a grid on the screen.
        /// </summary>
        private void DrawGrid()
        {
            int i = 0;
            int p = 0;
            for (int x = 0; x < Constants.MAX_X; x += Constants.CELL_SIZE)
            {
                Raylib.DrawLine(x, i, x, Constants.MAX_Y, Raylib_cs.Color.WHITE);
                i += Constants.CELL_SIZE;
                
            }
            for (int y = 0; y < Constants.MAX_Y; y += Constants.CELL_SIZE)
            {
                Raylib.DrawLine(p, y, Constants.MAX_X, y, Raylib_cs.Color.WHITE);
                p += Constants.CELL_SIZE;
            }
        }

        /// <summary>
        /// Converts the given color to it's Raylib equivalent.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>A Raylib color.</returns>
        private Raylib_cs.Color ToRaylibColor(Casting.Color color)
        {
            int r = color.GetRed();
            int g = color.GetGreen();
            int b = color.GetBlue();
            int a = color.GetAlpha();
            return new Raylib_cs.Color(r, g, b, a);
        }

    }
}