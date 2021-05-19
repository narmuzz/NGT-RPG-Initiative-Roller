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
      for (int i = 0; i < (EntityClass.PlayerList.Count); i++)
      {
        Console.Write(EntityClass.PlayerList[i].Name);
        Console.WriteLine($" | Initiative: {EntityClass.PlayerList[i].Initiative}");
      }
    }

    public static void PrintEnemySide()
    {
      Console.WriteLine("OPPOSING SIDE:");
      for (int i = 0; i < (EntityClass.EnemyList.Count); i++)
      {
        Console.Write(EntityClass.EnemyList[i].Name);
        Console.WriteLine($" | Initiative: {EntityClass.EnemyList[i].Initiative}");
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
