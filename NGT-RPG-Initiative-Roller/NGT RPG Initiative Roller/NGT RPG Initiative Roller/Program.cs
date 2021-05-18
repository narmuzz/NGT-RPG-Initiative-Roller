using System;
using System.Collections;
using System.Collections.Generic;

namespace NGT_RPG_Initiative_Roller
{
  class Program
  {
    static void Main(string[] args)
    {
      Program.Initialize();

      Program.Menu();
    }

    static void Initialize()
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
    }

    static void Menu()
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
          break;

        case 2:
          EntityClass.Ooc();
          break;

        case 3:
          EntityClass.AddAfterStart();
          break;

        case 4:
          //Export
          Console.WriteLine("Placeholder, going back to menu");
          break;
      }
      Program.Menu();
    }
  }
}
