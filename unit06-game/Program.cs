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
            cast.AddActor("enemy", new Enemy("enemy", "Z"));
            cast.AddActor("enemy", new Enemy("enemy2", "E"));
            cast.AddActor("enemy", new Enemy("enemy3", "M"));

            // obsticals
            cast.AddActor("obstical", new Obstical("obstical", "W"));
            cast.AddActor("obstical", new Obstical("obstical2","B"));
            cast.AddActor("obstical", new Obstical("obstical3","R"));

            // scrore borad
            Score score = new Score();
            score.SetPosition(new Point(400,0));
            cast.AddActor("score",  score);

            // Player 1's health
            Health Player1Health = new Health();
            Player1Health.SetText("Player 1 Health: 100");
            Player1Health.SetPosition(new Point(0, 0));
            cast.AddActor("health", Player1Health);

            // PLayer 2's health
            Health Player2Health = new Health();
            Player2Health.SetText("Player 2 Health: 100");
            Player2Health.SetPosition(new Point(750,0));
            cast.AddActor("health", Player2Health);

            // create the services
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);
           
            // create the script
            Script script = new Script();
            script.AddAction("input", new ControlActorsAction(keyboardService));
            script.AddAction("update", new MoveActorsAction());
            script.AddAction("update", new HandleEnemyPlayerCollisionsAction());
            //script.AddAction("update", new HandleObstacleCollisionsAction());
            script.AddAction("update", new HandleCollisionsAction());
            script.AddAction("output", new DrawActorsAction(videoService));

            // start the game
            Director director = new Director(videoService);
            director.StartGame(cast, script);
        }
    }
}
