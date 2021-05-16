using System;
using System.Collections.Generic;
using System.Text;

namespace NGT_RPG_Initiative_Roller
{
    class EntityClass
    {
        public string Name { get; set; }
        public int Initiative { get; set; }
        public bool PlayerWin { get; set; }

        public static void AddPlayerSide()
        {
            bool continueInput = true;

            for (int i = 0; continueInput == true; i++)
            {
                Console.WriteLine("Please enter a PLAYER character name. If you don't want to add any more, please enter 0");

                string temp = Console.ReadLine();
                switch (temp)
                {
                    case "0":
                    continueInput = false;
                    break;

                    default:
                    PlayerListClass.ls.Add(new EntityClass());
                    PlayerListClass.ls[i].Name = temp;
                    Console.WriteLine("Please enter that character's initiative score (minimum of 1, maximum of 5)");
                    PlayerListClass.ls[i].Initiative = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    break;
                }
            }
        }

        public static void AddEnemySide()
        {
            bool continueInput = true;

            for (int i = 0; continueInput == true; i++)
            {
                Console.WriteLine("Please enter an OPPOSING character name. If you don't want to add any more, please enter 0");

                string temp = Console.ReadLine();
                switch (temp)
                {
                    case "0":
                    continueInput = false;
                    break;

                    default:
                    EnemyListClass.ls.Add(new EntityClass());
                    EnemyListClass.ls[i].Name = temp;
                    Console.WriteLine("Please enter that character's initiative score (minimum of 1, maximum of 5)");
                    EnemyListClass.ls[i].Initiative = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    break;
                }
            }
        }

        public static void AddAfterStart()
        {
            Console.WriteLine("Please pick an option:");
            Console.WriteLine("1 = Add a player | 2 = Add an enemy | 3 = Go back to menu");
            int actionPicker = Convert.ToInt32(Console.ReadLine());
            switch (actionPicker)
            {
                case 1:
                    EntityClass.AddPlayerSide();
                    EntityClass.AddAfterStart();
                    break;

                case 2:
                    EntityClass.AddEnemySide();
                    EntityClass.AddAfterStart();
                    break;

                case 3:
                    MainScreenClass.PrintSides();

                    Console.WriteLine("");

                    InputActionPickerClass.Menu();
                    break;
            }
        }
    }
}
