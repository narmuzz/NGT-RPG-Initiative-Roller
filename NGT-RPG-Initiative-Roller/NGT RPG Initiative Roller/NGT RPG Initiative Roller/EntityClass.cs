using System;
using System.Collections.Generic;
using System.Text;

namespace NGT_RPG_Initiative_Roller
{
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
}
