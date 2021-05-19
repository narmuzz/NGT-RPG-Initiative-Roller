using System;
using System.Collections.Generic;
using System.Text;

namespace NGT_RPG_Initiative_Roller
{
    class DiceClass
    {
        public static Random Dice = new Random();
    }
    class Roller
    {
        public static void RollInitiative()
        {
            if (PlayerRoller() < EnemyRoller())
            {
                Console.WriteLine("The PLAYER side goes first");
            }
            //Tie breaker
            else if (PlayerRoller() == EnemyRoller())
            {
                Console.WriteLine("There was a tie; rolling again");
                Console.WriteLine("");
                Roller.RollInitiative();
            }
            else
            {
                Console.WriteLine("The OPPOSING side goes first");
                Console.WriteLine("The following player can perform 1 action before the opposing side if they forego their normal turn:");

                for (int i = 0; i < EntityClass.PlayerList.Count; i++)
                {
                    if (EntityClass.PlayerList[i].PlayerWin == true)
                    {
                        Console.WriteLine(EntityClass.PlayerList[i].Name);
                    }
                }
            }
        }

        private static int PlayerRoller()
        {
            for (int i = 0; i < EntityClass.PlayerList.Count; i++)
            {
                EntityClass.PlayerList[i].PlayerWin = false;
                if (DiceClass.Dice.Next(1, 7) <= EntityClass.PlayerList[i].Initiative)
                {
                    EntityClass.PlayerList[i].PlayerWin = true;
                }
            }

            int playerFailCount = 0;
            for (int i = 0; i < EntityClass.PlayerList.Count; i++)
            {
                if (EntityClass.PlayerList[i].PlayerWin == false)
                {
                    ++playerFailCount;
                }
            }
            return playerFailCount;
        }

        private static int EnemyRoller()
        {
            int enemyFailCount = 0;
            for (int i = 0; i < EntityClass.EnemyList.Count; i++)
            {
                if (DiceClass.Dice.Next(1, 7) > EntityClass.EnemyList[i].Initiative)
                {
                    ++enemyFailCount;
                }
            }
            return enemyFailCount;
        }

    }
}
