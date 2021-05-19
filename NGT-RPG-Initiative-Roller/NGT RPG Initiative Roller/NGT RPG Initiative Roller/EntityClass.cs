using System;
using System.Collections.Generic;
using System.Text;

namespace NGT_RPG_Initiative_Roller
{
  class EntityClass
  {
    public bool PlayerWin { get; set; }
    public static List<Entity> PlayerList = new List<Entity>();
    public static List<Entity> EnemyList = new List<Entity>();

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
            Entity player = new Entity();
            player.Name = temp;
            Console.WriteLine("Please enter that character's initiative score (minimum of 1, maximum of 5)");
            player.Initiative = Convert.ToInt32(Console.ReadLine());
            EntityClass.PlayerList.Add(player);
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
            Entity enemy = new Entity();
            enemy.Name = temp;
            Console.WriteLine("Please enter that character's initiative score (minimum of 1, maximum of 5)");
            enemy.Initiative = Convert.ToInt32(Console.ReadLine());
            EntityClass.EnemyList.Add(enemy);
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

          Program.Menu();
          break;
      }
    }

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
          for (int i = 0; i < EntityClass.PlayerList.Count; i++)
          {
            Console.WriteLine(i + " " + EntityClass.PlayerList[i].Name);
          }

          int pickPlayer = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("");

          Console.WriteLine($"{EntityClass.PlayerList[pickPlayer].Name} is now Out of Combat");
          EntityClass.PlayerList.RemoveAt(pickPlayer);

          EntityClass.Ooc();
          break;

        case 2:
          Console.WriteLine("Enter the index number of the desired entity");
          for (int i = 0; i < EntityClass.EnemyList.Count; i++)
          {
            Console.WriteLine(i + " " + EntityClass.EnemyList[i].Name);
          }

          int pickEnemy = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("");

          Console.WriteLine($"{EntityClass.EnemyList[pickEnemy].Name} is now Out of Combat");
          EntityClass.EnemyList.RemoveAt(pickEnemy);

          EntityClass.Ooc();
          break;

        case 3:
          MainScreenClass.PrintSides();

          Console.WriteLine("");

          Program.Menu();
          break;
      }
    }
  }
}
