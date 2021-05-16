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
            Console.WriteLine("Do you want to create a new sides table or would you prefer to import a csv?");
            Console.WriteLine("1 = Create new | 2 = Import");

            int newOrImport = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            switch (newOrImport)
            {
                case 1:
                    EntityClass.AddPlayerSide();
                    Console.WriteLine("");
                    Console.WriteLine("########################################################");
                    Console.WriteLine("");
                    EntityClass.AddEnemySide();
                    break;

                case 2:
                    //TO DO!
                    Console.WriteLine("Will now import a csv file with a previously exported sides table");
                    break;
            }

            MainScreenClass.PrintSides();

            Console.WriteLine("");

            InputActionPickerClass.Menu();

        }
    }
}
