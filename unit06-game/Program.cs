using Unit06.Game.Casting;
using Unit06.Game.Directing;
using Unit06.Game.Scripting;
using Unit06.Game.Services;

namespace Unit06
{
    class Program
    {
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast();

            //Players
            cast.AddActor("player", new Player("player1"));
            cast.AddActor("player", new Player("player2"));

            //enemies
            cast.AddActor("enemy", new Enemy("enemy", "E"));
            cast.AddActor("enemy", new Enemy("enemy2", "E"));
            cast.AddActor("enemy", new Enemy("enemy3", "E"));

            // obsticals
            cast.AddActor("obstical", new Obstical("obstical"));
            cast.AddActor("obstical", new Obstical("obstical2"));
            cast.AddActor("Obstical", new Obstical("obstical3"));

            // scrore borad
            Score score = new Score();
            score.SetPosition(new Point(400,0));
            cast.AddActor("score",  score);

            // Health about
            Health Player1Health = new Health();
            Player1Health.SetPosition(new Point(0, 0));
            cast.AddActor("score", Player1Health);
            Health Player2Health = new Health();
            Player2Health.SetPosition(new Point(700,0));
            cast.AddActor("score", Player2Health);

            // create the services
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);
           
            // create the script
            Script script = new Script();
            script.AddAction("input", new ControlActorsAction(keyboardService));
            script.AddAction("update", new MoveActorsAction());
            script.AddAction("update", new HandleCollisionsAction());
            script.AddAction("output", new DrawActorsAction(videoService));

            // start the game
            Director director = new Director(videoService);
            director.StartGame(cast, script);
        }
    }
}
