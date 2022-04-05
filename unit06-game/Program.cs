using Unit06.Game;
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

            
            // for (int i = 0; i < 5; i++)
            // {
                
                cast.AddActor("enemy", new Enemy("zombie", "Z", 6));
                cast.AddActor("enemy", new Enemy("skeleton", "S", 7));
                cast.AddActor("enemy", new Enemy("minator", "M", 8));

                
            // }

            

            // obsticals
            for (int i = 0; i < Constants.obsticalCap; i++ )
            {
                if ( i % 3 == 0)
                {
                    cast.AddActor("obstical", new Obstical("obstical", "W"));
                }
                else if ( i % 3 == 1 )
                {
                    cast.AddActor("obstical", new Obstical("obstical2", "B"));
                }
                else if ( i % 3 == 2)
                {
                    cast.AddActor("obstical", new Obstical("obstical3", "R"));
                }
            }
           
            


            // scrore borad
            Score score = new Score();
            score.SetPosition(new Point(425,0));
            cast.AddActor("score",  score);

            // Game Over text
            cast.AddActor("gameover", new GameOver());

            // instruction
            cast.AddActor("instruction", new Instruction());


            // Player 1's health
            Health Player1Health = new Health();
            Player1Health.SetText("Player 1 Health: 100");
            Player1Health.SetPosition(new Point(0, 0));
            cast.AddActor("health", Player1Health);

            // PLayer 2's health
            Health Player2Health = new Health();
            Player2Health.SetText("Player 2 Health: 100");
            Player2Health.SetPosition(new Point(750, 0));
            cast.AddActor("health", Player2Health);

            // create the services
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);
            AudioService audioService = new AudioService();
            
            // create the script
            Script script = new Script();
            script.AddAction("input", new ControlActorsAction(keyboardService));
            script.AddAction("update1", new ControlEnemyAction());
            script.AddAction("update1", new HandleEnemyOstacleCollisionsAction());
            script.AddAction("update1", new MoveActorsAction());
            script.AddAction("update1", new HandleEnemyPlayerCollisionsAction());
            script.AddAction("update1", new Attack(keyboardService, audioService));
            script.AddAction("update1", new HandleCollisionsAction());
            script.AddAction("update1", new HandleWeponCollisionsAction());
            script.AddAction("update1", new HandleGameoverAction());
            script.AddAction("update1", new HandleActorsDeath());
            script.AddAction("update1", new HandleEnemiesVisionsAction());
            script.AddAction("update1", new SpawnEnemy());
            script.AddAction("update2", new HandleSettingAction(keyboardService));
            
            // script.AddAction("update", new ControlEnemyAction());
            script.AddAction("output1", new DrawActorsAction(videoService));
            script.AddAction("output2", new DrawInstructionAction(videoService));


            // start the game
            Director director = new Director(videoService, keyboardService);
            director.StartGame(cast, script);
        }
    }
}
