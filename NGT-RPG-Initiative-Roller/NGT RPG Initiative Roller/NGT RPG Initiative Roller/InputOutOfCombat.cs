using System;
using System.Collections.Generic;
using System.Text;

namespace NGT_RPG_Initiative_Roller
{
    class InputOutOfCombat
    {
        public static void Ooc()
        {
            Console.WriteLine("Please pick an option:");
            Console.WriteLine("1 = Mark a player as OoC | 2 = Mark an enemy as OoC | 3 = Go back to menu");

            int actionPicker = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            switch (actionPicker)
            {
                case 1:
                    Console.WriteLine("Enter the index number of the desired entity");
                    for (int i = 0; i < PlayerListClass.ls.Count; i++)
                    {
                        Console.WriteLine(i + " " + PlayerListClass.ls[i].Name);
                    }

                    int pickPlayer = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    Console.WriteLine($"{PlayerListClass.ls[pickPlayer].Name} is now Out of Combat");
                    PlayerListClass.ls.RemoveAt(pickPlayer);

                    InputOutOfCombat.Ooc();
                    break;

                case 2:
                    Console.WriteLine("Enter the index number of the desired entity");
                    for (int i = 0; i < EnemyListClass.ls.Count; i++)
                    {
                        Console.WriteLine(i + " " + EnemyListClass.ls[i].Name);
                    }

                    int pickEnemy = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    Console.WriteLine($"{EnemyListClass.ls[pickEnemy].Name} is now Out of Combat");
                    EnemyListClass.ls.RemoveAt(pickEnemy);

                    InputOutOfCombat.Ooc();
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
