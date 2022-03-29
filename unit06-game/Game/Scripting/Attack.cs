using System;
using Unit06.Game.Casting;
using Unit06.Game.Services;
using System.Collections.Generic;

namespace Unit06.Game.Scripting
{
    public class Attack: Action
    {
        private int x = 0;
        private KeyboardService keyboardService;
        public Attack( KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }
        public void Execute(Cast cast, Script script)
        {
            List<Actor> players = cast.GetActors("player");
            List<Actor> enemy = cast.GetActors("enemy");
            Point currentSpot = players[x].GetPosition();
            int currentX = currentSpot.GetX();
            int currentY = currentSpot.GetY();
            string facing = players[x].getDirection();
            string fightClass = players[x].getFightClass(); 
            List<Point> attackzone = new List<Point>();
            for (int i=0 ; i <6 ; i++)
            {
                attackzone.Add(new Point(0,0));
            }

            if (fightClass == "knight" && keyboardService.IsKeyDown("e"))
            {
                if (facing == "left")
                {
                    attackzone[0] = new Point(currentX - Constants.CELL_SIZE, currentY);
                    attackzone[1] = new Point(currentX - (2*Constants.CELL_SIZE), currentY);
                    attackzone[2] = new Point(currentX - Constants.CELL_SIZE, currentY + Constants.CELL_SIZE);
                    attackzone[3] = new Point(currentX - (2*Constants.CELL_SIZE), currentY + Constants.CELL_SIZE);
                    attackzone[4] = new Point(currentX - Constants.CELL_SIZE, currentY - Constants.CELL_SIZE);
                    attackzone[5] = new Point(currentX - (2*Constants.CELL_SIZE), currentY - Constants.CELL_SIZE);
                    foreach (Actor enemys in enemy)
                    {
                        foreach (Point attack in attackzone)
                        {
                            Point enemysw = enemys.GetPosition();
                            int enemysx = enemysw.GetX();
                            int enemysy = enemysw.GetY();
                            int attackx = attack.GetX();
                            int attacky = attack.GetY();
                            if ( enemysx == attackx && enemysy == attacky)
                            {
                                enemys.SetHealth(10);
                                Console.WriteLine("hit");
                                Console.WriteLine(enemys.GetHealth());
                            }
                        }
                    }

                }
                if (facing == "right")
                {
                    attackzone[0] = new Point(currentX + Constants.CELL_SIZE, currentY);
                    attackzone[1] = new Point(currentX + (2*Constants.CELL_SIZE), currentY);
                    attackzone[2] = new Point(currentX + Constants.CELL_SIZE, currentY + Constants.CELL_SIZE);
                    attackzone[3] = new Point(currentX + (2*Constants.CELL_SIZE), currentY + Constants.CELL_SIZE);
                    attackzone[4] = new Point(currentX + Constants.CELL_SIZE, currentY - Constants.CELL_SIZE);
                    attackzone[5] = new Point(currentX + (2*Constants.CELL_SIZE), currentY - Constants.CELL_SIZE);
                    foreach (Actor enemys in enemy)
                    {
                        foreach (Point attack in attackzone)
                        {
                            Point enemysw = enemys.GetPosition();
                            int enemysx = enemysw.GetX();
                            int enemysy = enemysw.GetY();
                            int attackx = attack.GetX();
                            int attacky = attack.GetY();
                            if ( enemysx == attackx && enemysy == attacky)
                            {
                                enemys.SetHealth(10);
                                Console.WriteLine("hit");
                                Console.WriteLine(enemys.GetHealth());
                            }
                        }
                    }

                }
                if (facing == "up")
                {
                    attackzone[0] = new Point(currentX, currentY - Constants.CELL_SIZE);
                    attackzone[1] = new Point(currentX, currentY  - (2*Constants.CELL_SIZE));
                    attackzone[2] = new Point(currentX + Constants.CELL_SIZE, currentY - Constants.CELL_SIZE);
                    attackzone[3] = new Point(currentX + Constants.CELL_SIZE, currentY - (2*Constants.CELL_SIZE));
                    attackzone[4] = new Point(currentX - Constants.CELL_SIZE, currentY - Constants.CELL_SIZE);
                    attackzone[5] = new Point(currentX - Constants.CELL_SIZE, currentY - (2*Constants.CELL_SIZE));
                    foreach (Actor enemys in enemy)
                    {
                        foreach (Point attack in attackzone)
                        {
                            Point enemysw = enemys.GetPosition();
                            int enemysx = enemysw.GetX();
                            int enemysy = enemysw.GetY();
                            int attackx = attack.GetX();
                            int attacky = attack.GetY();
                            if ( enemysx == attackx && enemysy == attacky)
                            {
                                enemys.SetHealth(10);
                                Console.WriteLine("hit");
                                Console.WriteLine(enemys.GetHealth());
                            }
                        }
                    }
                }
                if (facing == "down")
                {
                    attackzone[0] = new Point(currentX, currentY + Constants.CELL_SIZE);
                    attackzone[1] = new Point(currentX, currentY  + (2*Constants.CELL_SIZE));
                    attackzone[2] = new Point(currentX + Constants.CELL_SIZE, currentY + Constants.CELL_SIZE);
                    attackzone[3] = new Point(currentX + Constants.CELL_SIZE, currentY + (2*Constants.CELL_SIZE));
                    attackzone[4] = new Point(currentX - Constants.CELL_SIZE, currentY + Constants.CELL_SIZE);
                    attackzone[5] = new Point(currentX - Constants.CELL_SIZE, currentY + (2*Constants.CELL_SIZE));
                    foreach (Actor enemys in enemy)
                    {
                        foreach (Point attack in attackzone)
                        {
                            Point enemysw = enemys.GetPosition();
                            int enemysx = enemysw.GetX();
                            int enemysy = enemysw.GetY();
                            int attackx = attack.GetX();
                            int attacky = attack.GetY();
                            if ( enemysx == attackx && enemysy == attacky)
                            {
                                enemys.SetHealth(10);
                                Console.WriteLine("hit");
                                Console.WriteLine(enemys.GetHealth());
                            }
                        }
                    }                
                }
            }
            else if (fightClass == "archer" && keyboardService.IsKeyDown("o"))
            {
                Console.WriteLine("Arrow");
                x = 1;
                if (facing == "left")
                {
                    attackzone[0] = new Point(currentX - Constants.CELL_SIZE, currentY);
                    attackzone[1] = new Point(currentX - (2*Constants.CELL_SIZE), currentY);
                    attackzone[2] = new Point(currentX - (3*Constants.CELL_SIZE), currentY);
                    attackzone[3] = new Point(currentX - (4*Constants.CELL_SIZE), currentY);
                    attackzone[4] = new Point(currentX - (5*Constants.CELL_SIZE), currentY);
                    attackzone[5] = new Point(currentX - (6*Constants.CELL_SIZE), currentY);
                    foreach (Actor enemys in enemy)
                    {
                        foreach (Point attack in attackzone)
                        {
                            Point enemysw = enemys.GetPosition();
                            int enemysx = enemysw.GetX();
                            int enemysy = enemysw.GetY();
                            int attackx = attack.GetX();
                            int attacky = attack.GetY();
                            if ( enemysx == attackx && enemysy == attacky)
                            {
                                enemys.SetHealth(10);
                                Console.WriteLine("hit");
                                Console.WriteLine(enemys.GetHealth());
                            }
                        }
                    }
                }
                if (facing == "right")
                {
                    attackzone[0] = new Point(currentX + Constants.CELL_SIZE, currentY);
                    attackzone[1] = new Point(currentX + (2*Constants.CELL_SIZE), currentY);
                    attackzone[2] = new Point(currentX + (3*Constants.CELL_SIZE), currentY);
                    attackzone[3] = new Point(currentX + (4*Constants.CELL_SIZE), currentY);
                    attackzone[4] = new Point(currentX + (5*Constants.CELL_SIZE), currentY);
                    attackzone[5] = new Point(currentX + (6*Constants.CELL_SIZE), currentY);
                    foreach (Actor enemys in enemy)
                    {
                        foreach (Point attack in attackzone)
                        {
                            Point enemysw = enemys.GetPosition();
                            int enemysx = enemysw.GetX();
                            int enemysy = enemysw.GetY();
                            int attackx = attack.GetX();
                            int attacky = attack.GetY();
                            if ( enemysx == attackx && enemysy == attacky)
                            {
                                enemys.SetHealth(10);
                                Console.WriteLine("hit");
                                Console.WriteLine(enemys.GetHealth());
                            }
                        }
                    }                
                }
                if (facing == "up")
                {
                    attackzone[0] = new Point(currentX, currentY - Constants.CELL_SIZE);
                    attackzone[1] = new Point(currentX, currentY - (2*Constants.CELL_SIZE));
                    attackzone[2] = new Point(currentX, currentY - (3*Constants.CELL_SIZE));
                    attackzone[3] = new Point(currentX, currentY - (4*Constants.CELL_SIZE));
                    attackzone[4] = new Point(currentX, currentY - (5*Constants.CELL_SIZE));
                    attackzone[5] = new Point(currentX, currentY - (6*Constants.CELL_SIZE)); 
                    foreach (Actor enemys in enemy)
                    {
                        foreach (Point attack in attackzone)
                        {
                            Point enemysw = enemys.GetPosition();
                            int enemysx = enemysw.GetX();
                            int enemysy = enemysw.GetY();
                            int attackx = attack.GetX();
                            int attacky = attack.GetY();
                            if ( enemysx == attackx && enemysy == attacky)
                            {
                                enemys.SetHealth(10);
                                Console.WriteLine("hit");
                                Console.WriteLine(enemys.GetHealth());
                            }
                        }
                    }               
                }
                if (facing == "down")
                {
                    attackzone[0] = new Point(currentX, currentY + Constants.CELL_SIZE);
                    attackzone[1] = new Point(currentX, currentY + (2*Constants.CELL_SIZE));
                    attackzone[2] = new Point(currentX, currentY + (3*Constants.CELL_SIZE));
                    attackzone[3] = new Point(currentX, currentY + (4*Constants.CELL_SIZE));
                    attackzone[4] = new Point(currentX, currentY + (5*Constants.CELL_SIZE));
                    attackzone[5] = new Point(currentX, currentY + (6*Constants.CELL_SIZE));
                    foreach (Actor enemys in enemy)
                    {
                        foreach (Point attack in attackzone)
                        {
                            Point enemysw = enemys.GetPosition();
                            int enemysx = enemysw.GetX();
                            int enemysy = enemysw.GetY();
                            int attackx = attack.GetX();
                            int attacky = attack.GetY();
                            if ( enemysx == attackx && enemysy == attacky)
                            {
                                enemys.SetHealth(10);
                                Console.WriteLine("hit");
                                Console.WriteLine(enemys.GetHealth());
                            }
                        }
                    }
                }
            }
        }  
    }
}