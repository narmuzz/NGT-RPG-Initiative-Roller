using System;
using System.Collections.Generic;
using System.Text;

namespace NGT_RPG_Initiative_Roller
{
    class InputActionPickerClass
    {
        public static void Menu()
        {
            Console.WriteLine("Please pick an option:");
            Console.WriteLine("1 = Roll for initiative | 2 = Mark someone as Out of Combat (OoC) | 3 = Add someone to either side | 4 = Export to CSV");

            int actionPicker = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            switch (actionPicker)
            {
                case 1:
                    Roller.RollInitiative();
                    Console.WriteLine("");
                    MainScreenClass.PrintSides();
                    InputActionPickerClass.Menu();
                    break;

                case 2:
                    InputOutOfCombat.Ooc();
                    break;

                case 3:
                    EntityClass.AddAfterStart();
                    break;

                case 4:
                    //Export
                    Console.WriteLine("Placeholder, going back to menu");
                    InputActionPickerClass.Menu();
                    break;
            }
        }
    }
}
