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

            List<Actor> score = cast.GetActors("score");

            List<Actor> health = cast.GetActors("health");
            List<Actor> sword = cast.GetActors("sword");
            List<Actor> arrows = cast.GetActors("arrow");
            
            videoService.ClearBuffer();
            // videoService.DrawActors(segments);
            // videoService.DrawActors(segments2);
            // videoService.DrawActor(score);
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
            foreach (Actor scores in score)
            {
                videoService.DrawActor(scores);
            }

            // Display Health
            foreach (Actor healty in health)
            {
                videoService.DrawActor(healty);
            }

            // Display Sword
            foreach(Actor swords in sword)
            {
                videoService.DrawActor(swords);
            }

            // Display Arrows
            foreach(Actor arrow in arrows)
            {
                videoService.DrawActor(arrow);
            }
            // videoService.DrawActors(messages);
            videoService.FlushBuffer();
        }
    }
}