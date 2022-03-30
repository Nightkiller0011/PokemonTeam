using System;
using System.Collections.Generic;
using System.Data;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class HandleGameoverAction : Action
    {
        private bool _gameover;
        private List<string> _groups = new List<string>(3){"player", "obstical", "enemy"};

        private string _message;

        public HandleGameoverAction()
        {
            _gameover = false;
            _message = "Game Over";
        }

        public void Execute(Cast cast, Script script)
        {
            List<Actor> players = cast.GetActors("player");

            foreach (Actor player in players)
            {
                int health = player.GetHealth();
                if (health <= 0)
                {
                    player.SetColor(Constants.WHITE);
                    //cast.RemoveActor("player", player);
                }
            }
        }

        private void SetAllThingsWhite(Cast cast)
        {
            List<Actor> actors = cast.GetAllActors();

            foreach (Actor actor in actors)
            {
                actor.SetColor(Constants.WHITE);
            }
        }

        private void RemoveAllActors(Cast cast)
        {
            foreach(string group in _groups)
            {
                List<Actor> actors = cast.GetActors(group);
                foreach(Actor actor in actors)
                {
                    cast.RemoveActor(group, actor);
                }
            }
        }
    }
}