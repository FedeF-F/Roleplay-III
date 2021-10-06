using System.Collections.Generic;
using System.Collections;
using System;


namespace RoleplayGame
{
    public class Encounter
    {
        public void DoEncounter(List<Character> Heroes, List<Character> Enemies)
        {
            int Herocount = Heroes.Count;
            int target = 0;
            int Enemycount = Enemies.Count;
            while (Herocount > 0 & Enemycount > 0)
            {
                foreach (Enemy Enemy in Enemies)
                {
                    Heroes[target].ReceiveAttack(Enemy.AttackValue, 0);
                    target = (target+1)%Herocount;
                    if (Heroes[target].Health <= 0)
                    {
                        Heroes.Remove(Heroes[target]);
                    }
                }
            
                foreach (Character Hero in Heroes)
                {
                    foreach (Enemy Enemy in Enemies)
                    {   
                        target = (target+1)%Enemycount;
                        Enemies[target].ReceiveAttack(Hero.AttackValue, Enemy.VPGiven );
                        if (Enemies[target].Health <= 0)
                        {
                            Enemies.Remove(Enemies[target]);
                        }
                    }
                }
                Enemycount = Enemies.Count;
                Herocount = Heroes.Count;
            }
            foreach (Character Hero in Heroes)
            {
                {
                    if (Hero.VictoryPoints >= 5)
                    {
                        Hero.Cure();
                    }
                }
            }

        }
    }

}

