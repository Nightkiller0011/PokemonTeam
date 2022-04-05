using Unit06.Game.Casting;
using Unit06.Game.Services;
using System.Collections.Generic;
using System;
namespace Unit06.Game.Scripting
{
    public class HandleSettingAction : Action
    {
        private KeyboardService keyboardService;

        public HandleSettingAction(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        public void Execute(Cast cast, Script script)
        {
            Actor instruction = cast.GetFirstActor("instruction");
            if (keyboardService.IsKeyDown("0"))
            {
                ShowInstruction(instruction);
            }
            else if (keyboardService.IsKeyDown("1"))
            {
                List<Actor> players = cast.GetActors("player");
                players[1].SetText("");
                players[1].SetHealth(100);
                players[0].SetPosition(new Point(450, 585));
                List<Actor> healths = cast.GetActors("health");
                healths[1].SetText("");
                instruction.SetText("1-player game has set. Press spacebar to start the game.");
                instruction.SetPosition(new Point(250, 300));
            }
            // else if (keyboardService.IsKeyDown("2"))
            // {
            //     List<Actor> players = cast.GetActors("player");
            //     players[1].SetText("&");
            //     players[0].SetPosition(new Point(300, 585));
            //     // players[1].SetPosition(new Point(600, 585));
            // }
        }

        private void ShowInstruction(Actor instruction)
        {   
            instruction.SetText("For player 1: press W, A, S, D to move the character, press E to attack \nFor player 2: press I, J, K, L to move the charater, press O the attack \n                  The game is automatically set as 2-player game, \n                 press 1 if you want to change it to 1-player game\n                        Or press spacebar to start the game");
            instruction.SetPosition(new Point(180, 240));
        }

        private void CloseInstruction(Actor instruction)
        {
            instruction.SetText("");
        }
    }
}

