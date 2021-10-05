using System.Collections.Generic;
using System.Collections;
using System;
namespace RoleplayGame
{
    public class Encounter
    {
        public void CombatEncounter(ArrayList Heroes, ArrayList Enemies)
        {
            int count = Heroes.Count;
            int target = 0;
            foreach (Enemy Enemy in Enemies)
            {
                Heroes[target].ReceiveAttack(Enemy.AttackValue, 0);
                target = (target+1)%count;
                if (Heroes[target].Health <= 0)
                {
                    Heroes.Remove(Heroes[target]);
                    count = Heroes.Count;
                    if (count == 0)
                    {
                    Console.WriteLine("The heroes have been defeated");
                    break;
                    }

                }
            }

        }
    }
}