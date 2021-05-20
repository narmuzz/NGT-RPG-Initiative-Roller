using System;
using System.Collections.Generic;
using System.Text;

namespace NGT_RPG_Initiative_Roller
{
  class EntityManager
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
            player.Initiative = MainScreenClass.AskOptionWithRetries(1, 5);
            EntityManager.PlayerList.Add(player);
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
            enemy.Initiative = MainScreenClass.AskOptionWithRetries(1, 5);
            EntityManager.EnemyList.Add(enemy);
            Console.WriteLine("");
            break;
        }
      }
    }

    public static void AddAfterStart()
    {
      Console.WriteLine("Please pick an option:");
      Console.WriteLine("1 = Add a player | 2 = Add an enemy | 3 = Go back to menu");
      int actionPicker = MainScreenClass.AskOptionWithRetries(1, 3);
      switch (actionPicker)
      {
        case 1:
          EntityManager.AddPlayerSide();
          EntityManager.AddAfterStart();
          break;

        case 2:
          EntityManager.AddEnemySide();
          EntityManager.AddAfterStart();
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

      int actionPicker = MainScreenClass.AskOptionWithRetries(1, 3);
      Console.WriteLine("");

      switch (actionPicker)
      {
        case 1:
          Console.WriteLine("Enter the index number of the desired entity");
          for (int i = 0; i < EntityManager.PlayerList.Count; i++)
          {
            Console.WriteLine(i + " " + EntityManager.PlayerList[i].Name);
          }

          int pickPlayer = MainScreenClass.AskOptionWithRetries(0, EntityManager.PlayerList.Count - 1);
          Console.WriteLine("");

          Console.WriteLine($"{EntityManager.PlayerList[pickPlayer].Name} is now Out of Combat");
          EntityManager.PlayerList.RemoveAt(pickPlayer);

          EntityManager.Ooc();
          break;

        case 2:
          Console.WriteLine("Enter the index number of the desired entity");
          for (int i = 0; i < EntityManager.EnemyList.Count; i++)
          {
            Console.WriteLine(i + " " + EntityManager.EnemyList[i].Name);
          }

          int pickEnemy = MainScreenClass.AskOptionWithRetries(0, EntityManager.EnemyList.Count - 1);
          Console.WriteLine("");

          Console.WriteLine($"{EntityManager.EnemyList[pickEnemy].Name} is now Out of Combat");
          EntityManager.EnemyList.RemoveAt(pickEnemy);

          EntityManager.Ooc();
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
