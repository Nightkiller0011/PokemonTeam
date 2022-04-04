using System;
using Unit06.Game.Casting;
using Unit06.Game.Services;
using System.Collections.Generic;

namespace Unit06.Game.Scripting
{
    public class Attack: Action
    {
        
        private KeyboardService keyboardService;
        private AudioService audioService;
        public Attack( KeyboardService keyboardService, AudioService audioService)
        {
            this.keyboardService = keyboardService;
            this.audioService = audioService;
        }
        public void Execute(Cast cast, Script script)
        {
            List<Knight> sword = new List<Knight>();
            List<Arrow> arrows = new List<Arrow>();
            List<Actor> players = cast.GetActors("player");
            List<Actor> enemy = cast.GetActors("enemy");
            Actor score = cast.GetFirstActor("score");
            Point currentSpot = players[0].GetPosition();
            Point currentSpot2 = players[1].GetPosition();
            int currentX = currentSpot.GetX();
            int currentY = currentSpot.GetY();
            int currentX2 = currentSpot2.GetX();
            int currentY2 = currentSpot2.GetY();
            string facing = players[0].getDirection();
            string facing2 = players[1].getDirection();
            string fightClass = players[0].getFightClass(); 
            string fightClass2 = players[1].getFightClass();
            bool Hit = false;
            List<Point> attackzone = new List<Point>();
            List<Point> attackzone2 = new List<Point>();

            for (int i=0 ; i <6 ; i++)
            {
                attackzone.Add(new Point(0,0));
                attackzone2.Add(new Point(0,0));
                sword.Add(new Knight());
                arrows.Add(new Arrow());
            }

            if (fightClass == "knight" && keyboardService.IsKeyDown("e") && players[0].GetHealth() > 0)
            {
                if (facing == "left")
                {
                    attackzone[0] = new Point(currentX - Constants.CELL_SIZE, currentY);
                    attackzone[1] = new Point(currentX - (2*Constants.CELL_SIZE), currentY);
                    attackzone[2] = new Point(currentX - Constants.CELL_SIZE, currentY + Constants.CELL_SIZE);
                    attackzone[3] = new Point(currentX - (2*Constants.CELL_SIZE), currentY + Constants.CELL_SIZE);
                    attackzone[4] = new Point(currentX - Constants.CELL_SIZE, currentY - Constants.CELL_SIZE);
                    attackzone[5] = new Point(currentX - (2*Constants.CELL_SIZE), currentY - Constants.CELL_SIZE);
                }
                if (facing == "right")
                {
                    attackzone[0] = new Point(currentX + Constants.CELL_SIZE, currentY);
                    attackzone[1] = new Point(currentX + (2*Constants.CELL_SIZE), currentY);
                    attackzone[2] = new Point(currentX + Constants.CELL_SIZE, currentY + Constants.CELL_SIZE);
                    attackzone[3] = new Point(currentX + (2*Constants.CELL_SIZE), currentY + Constants.CELL_SIZE);
                    attackzone[4] = new Point(currentX + Constants.CELL_SIZE, currentY - Constants.CELL_SIZE);
                    attackzone[5] = new Point(currentX + (2*Constants.CELL_SIZE), currentY - Constants.CELL_SIZE);
                }
                if (facing == "up")
                {
                    attackzone[0] = new Point(currentX, currentY - Constants.CELL_SIZE);
                    attackzone[1] = new Point(currentX, currentY  - (2*Constants.CELL_SIZE));
                    attackzone[2] = new Point(currentX + Constants.CELL_SIZE, currentY - Constants.CELL_SIZE);
                    attackzone[3] = new Point(currentX + Constants.CELL_SIZE, currentY - (2*Constants.CELL_SIZE));
                    attackzone[4] = new Point(currentX - Constants.CELL_SIZE, currentY - Constants.CELL_SIZE);
                    attackzone[5] = new Point(currentX - Constants.CELL_SIZE, currentY - (2*Constants.CELL_SIZE));
                }
                if (facing == "down")
                {
                    Console.WriteLine(fightClass2);
                    attackzone[0] = new Point(currentX, currentY + Constants.CELL_SIZE);
                    attackzone[1] = new Point(currentX, currentY  + (2*Constants.CELL_SIZE));
                    attackzone[2] = new Point(currentX + Constants.CELL_SIZE, currentY + Constants.CELL_SIZE);
                    attackzone[3] = new Point(currentX + Constants.CELL_SIZE, currentY + (2*Constants.CELL_SIZE));
                    attackzone[4] = new Point(currentX - Constants.CELL_SIZE, currentY + Constants.CELL_SIZE);
                    attackzone[5] = new Point(currentX - Constants.CELL_SIZE, currentY + (2*Constants.CELL_SIZE));             
                }
                for (int i = 0; i < 6; i++)
                {
                    sword[i].SetPosition(attackzone[i]);
                    cast.AddActor("sword", sword[i]);
                }
                Hit = IsThereACollision(attackzone,enemy,Hit);
                Playsound(Hit);
            }

            

            if (fightClass2 == "archer" && keyboardService.IsKeyDown("o") && players[1].GetHealth() > 0)
            {
                if (facing2 == "left")
                {
                    attackzone2[0] = new Point(currentX2 - Constants.CELL_SIZE, currentY2);
                    attackzone2[1] = new Point(currentX2 - (2*Constants.CELL_SIZE), currentY2);
                    attackzone2[2] = new Point(currentX2 - (3*Constants.CELL_SIZE), currentY2);
                    attackzone2[3] = new Point(currentX2 - (4*Constants.CELL_SIZE), currentY2);
                    attackzone2[4] = new Point(currentX2 - (5*Constants.CELL_SIZE), currentY2);
                    attackzone2[5] = new Point(currentX2 - (6*Constants.CELL_SIZE), currentY2);
                }
                if (facing2 == "right")
                {
                    attackzone2[0] = new Point(currentX2 + Constants.CELL_SIZE, currentY2);
                    attackzone2[1] = new Point(currentX2 + (2*Constants.CELL_SIZE), currentY2);
                    attackzone2[2] = new Point(currentX2 + (3*Constants.CELL_SIZE), currentY2);
                    attackzone2[3] = new Point(currentX2 + (4*Constants.CELL_SIZE), currentY2);
                    attackzone2[4] = new Point(currentX2 + (5*Constants.CELL_SIZE), currentY2);
                    attackzone2[5] = new Point(currentX2 + (6*Constants.CELL_SIZE), currentY2);             
                }
                if (facing2 == "up")
                {
                    attackzone2[0] = new Point(currentX2, currentY2 - Constants.CELL_SIZE);
                    attackzone2[1] = new Point(currentX2, currentY2 - (2*Constants.CELL_SIZE));
                    attackzone2[2] = new Point(currentX2, currentY2 - (3*Constants.CELL_SIZE));
                    attackzone2[3] = new Point(currentX2, currentY2 - (4*Constants.CELL_SIZE));
                    attackzone2[4] = new Point(currentX2, currentY2 - (5*Constants.CELL_SIZE));
                    attackzone2[5] = new Point(currentX2, currentY2 - (6*Constants.CELL_SIZE));              
                }
                if (facing2 == "down")
                {
                    attackzone2[0] = new Point(currentX2, currentY2 + Constants.CELL_SIZE);
                    attackzone2[1] = new Point(currentX2, currentY2 + (2*Constants.CELL_SIZE));
                    attackzone2[2] = new Point(currentX2, currentY2 + (3*Constants.CELL_SIZE));
                    attackzone2[3] = new Point(currentX2, currentY2 + (4*Constants.CELL_SIZE));
                    attackzone2[4] = new Point(currentX2, currentY2 + (5*Constants.CELL_SIZE));
                    attackzone2[5] = new Point(currentX2, currentY2 + (6*Constants.CELL_SIZE));
                }
                for (int i = 0; i < 6; i++)
                {
                    arrows[i].SetPosition(attackzone2[i]);
                    cast.AddActor("arrow", arrows[i]);
                }
                Hit = IsThereACollision(attackzone2,enemy,Hit);
                Playsound(Hit);
            }
        }
        public void Playsound(bool play)
        {
            if(play)
            {
                audioService.playsound("Assats/Assets/ElectronOrDectetorHit.wav");
            }
            
        } 
        public bool IsThereACollision(List<Point> attackzone,List<Actor> enemys, bool hit)
        {
            foreach (Actor enemy in enemys)
            {
                foreach (Point attack in attackzone)
                {
                    Point enemysw = enemy.GetPosition();
                    int enemysx = enemysw.GetX();
                    int enemysy = enemysw.GetY();
                    int attackx = attack.GetX();
                    int attacky = attack.GetY();
                    if ( enemysx == attackx && enemysy == attacky)
                    {
                        enemy.SetHealth(50);
                        hit = true;
                    }            
                }
            }
            return hit;
        } 
    }
}