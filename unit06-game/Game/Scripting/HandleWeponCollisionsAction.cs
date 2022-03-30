using System;
using System.Collections.Generic;
using System.Data;
using Unit06.Game.Casting;
using Unit06.Game.Services;

namespace Unit06.Game.Scripting
{
    public class HandleWeponCollisionsAction : Action
    {
        private int time = 0;
        public HandleWeponCollisionsAction()
        {

        }
        public void Execute(Cast cast, Script script)
        {
            List<Actor> enemys = cast.GetActors("enemy");
            List<Actor> swords = cast.GetActors("sword");
            List<Actor> arrows = cast.GetActors("arrow");
            if (time == 5)
            {
                foreach ( Actor sword in swords)
                {
                    cast.RemoveActor("sword", sword);               
                }
                foreach (Actor arrow in arrows)
                {
                    cast.RemoveActor("arrow", arrow);
                }
                time = 0;
            }
            time += 1;
        }
    }
}