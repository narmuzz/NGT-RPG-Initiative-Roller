using System;
using System.Collections;
using System.Collections.Generic;

namespace NGT_RPG_Initiative_Roller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###############################");
            Console.WriteLine("# NGT RPG - INITIATIVE ROLLER #");
            Console.WriteLine("###############################");
            Console.WriteLine("            2021");
            Console.WriteLine("");
            Console.WriteLine("Do you want to create new sides table or would you prefer to import a csv?");
            Console.WriteLine("1 = Create new | 2 = Import");

            int newOrImport = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            switch (newOrImport)
            {
                case 1:
                    EntityClass.AddPlayerSide();
                    EntityClass.AddEnemySide();
                    break;

                case 2:
                    Console.WriteLine("Will now import a csv file with a previously exported sides table");
                    break;
            }

            //test
            MainScreenClass.PrintPlayerSide();
            Console.WriteLine("");
            MainScreenClass.PrintEnemySide();

        }
    }

    class PlayerListClass
    {
        public static List<EntityClass> ls = new List<EntityClass>();
    }

    class EnemyListClass
    {
        public static List<EntityClass> ls = new List<EntityClass>();
    }

    class EntityClass
    {
        public string Name { get; set; }
        public int Initiative { get; set; }

        public static void AddPlayerSide()
        {
            Console.WriteLine("Will now enter the player characters");
            Console.WriteLine("");

            bool continueInput = true;

            for (int i = 0; continueInput == true; i++)
            {
                PlayerListClass.ls.Add(new EntityClass());

                Console.WriteLine("Please enter a player character name");
                PlayerListClass.ls[i].Name = Console.ReadLine();

                Console.WriteLine("Please enter that character's initiative score (minimum of 1, maximum of 5)");
                PlayerListClass.ls[i].Initiative = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Do you wish to enter another opposing character?");
                Console.WriteLine("1 = Yes | 2 = No");
                int yesNo_continuePlayerCharacterInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (yesNo_continuePlayerCharacterInput == 2)
                {
                    continueInput = false;
                }
            }

        }

        public static void AddEnemySide()
        {
            Console.WriteLine("Will now enter the opposing non-player characters");
            Console.WriteLine("");

            bool continueInput = true;

            for (int i = 0; continueInput == true; i++)
            {
                EnemyListClass.ls.Add(new EntityClass());

                Console.WriteLine("Please enter an opposing character name");
                EnemyListClass.ls[i].Name = Console.ReadLine();

                Console.WriteLine("Please enter that character's initiative score (minimum of 1, maximum of 5)");
                EnemyListClass.ls[i].Initiative = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Do you wish to enter another opposing character?");
                Console.WriteLine("1 = Yes | 2 = No");
                int yesNo_continuePlayerCharacterInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (yesNo_continuePlayerCharacterInput == 2)
                {
                    continueInput = false;
                }
            }

        }

    }

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
    }
}
