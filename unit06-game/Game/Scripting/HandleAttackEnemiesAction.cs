using Unit06.Game.Casting;
using Unit06.Game.Services;
using System.Collections.Generic;
using System;
namespace Unit06.Game.Scripting
{
    public class HandleAttackEnemiesAction : Action
    {
        public HandleAttackEnemiesAction()
        {

        }

        public void Execute(Cast cast, Script script)
        {
            List<Actor> swordAttacks = cast.GetActors("sword");
            List<Actor> enemies = cast.GetActors("enemy");
            
            foreach (Actor swordAttack in swordAttacks)
            {
                foreach (Actor enemy in enemies)
                {
                    if (swordAttack.GetPosition().Equals(enemy.GetPosition()))
                    {
                        enemy.SetHealth(5);
                    }
                }
            }
        }
    }
}