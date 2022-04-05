using System.Collections.Generic;
using Unit06.Game.Casting;
using Unit06.Game.Services;

namespace Unit06.Game.Scripting
{
    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
    /// </summary>
    public class DrawInstructionAction : Action
    {
        private VideoService videoService;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public DrawInstructionAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            Actor instruction = cast.GetFirstActor("instruction");

            
            videoService.ClearBuffer();

            // Display Instruction
            videoService.DrawActor(instruction);

            // videoService.DrawActors(messages);
            videoService.FlushBuffer();
        }
    }
}

