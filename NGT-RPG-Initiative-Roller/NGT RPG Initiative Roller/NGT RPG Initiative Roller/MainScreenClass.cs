using System;
using System.Collections.Generic;
using System.Text;

namespace NGT_RPG_Initiative_Roller
{
    class MainScreenClass
    {
        public static void PrintPlayerSide()
        {
            Console.WriteLine("PLAYER SIDE:");
            for (int i = 0; i < (PlayerListClass.ls.Count); i++)
            {
                Console.Write(PlayerListClass.ls[i].Name);
                Console.WriteLine($" | Initiative: {PlayerListClass.ls[i].Initiative}");
            }
        }

        public static void PrintEnemySide()
        {
            Console.WriteLine("OPPOSING SIDE:");
            for (int i = 0; i < (EnemyListClass.ls.Count); i++)
            {
                Console.Write(EnemyListClass.ls[i].Name);
                Console.WriteLine($" | Initiative: {EnemyListClass.ls[i].Initiative}");
            }
        }

        public static void PrintSides()
        {
            Console.WriteLine("");
            Console.WriteLine("######################################################################");
            Console.WriteLine("");
            MainScreenClass.PrintPlayerSide();
            Console.WriteLine("");
            MainScreenClass.PrintEnemySide();
        }
    }
}
