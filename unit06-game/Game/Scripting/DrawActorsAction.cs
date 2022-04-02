using System.Collections.Generic;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
    /// </summary>
    public class DrawActorsAction : Action
    {
        private VideoService videoService;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public DrawActorsAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            
            List<Actor> messages = cast.GetActors("messages");

            List<Actor> players = cast.GetActors("player");

            List<Actor> enemys = cast.GetActors("enemy");

            List<Actor> obsticals = cast.GetActors("obstical");

            Actor score = cast.GetFirstActor("score");

            List<Actor> health = cast.GetActors("health");
            List<Actor> sword = cast.GetActors("sword");
            List<Actor> arrows = cast.GetActors("arrow");
            Actor gameover = cast.GetFirstActor("gameover");
            
            videoService.ClearBuffer();
            
            foreach (Actor player in players)
            {
                videoService.DrawActor(player);
            }

            // Displays enemies
            foreach (Actor enemy in enemys)
            {
                videoService.DrawActor(enemy);
            }

            // Display obsticals
            foreach (Actor obstical in obsticals)
            {
                videoService.DrawActor(obstical);
            }

            // Display Score 
            videoService.DrawActor(score);
            

            // Display Health
            videoService.DrawActors(health);
            

            // Display Sword
            videoService.DrawActors(sword);
    
            // Display Arrows
            videoService.DrawActors(arrows);

            // Display Game Over
            videoService.DrawActor(gameover);

            // videoService.DrawActors(messages);
            videoService.FlushBuffer();
        }
    }
}