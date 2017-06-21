using System;
using System.Collections.Generic;

namespace CastleGrimtol.Game
{
  public class Player : IPlayer
  {
    public string PlayerName;
   public  int Score { get; set; }
    public List<Item> Inventory { get; set; }
    public Player()
    {
      PlayerName = CurrentPlayer();
      Score = 0;
      Inventory = new List<Item>();
    }
    public void ShowInventory(Player player)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      System.Console.WriteLine("You are holding:\n");
      for (int i = 0; i < player.Inventory.Count; i++)
      {
        System.Console.WriteLine($"{player.Inventory[i].Name}");
        System.Console.WriteLine($"{player.Inventory[i].Description}\n");
      }
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    public string CurrentPlayer()
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write("Please enter your name: ");
      PlayerName = Console.ReadLine();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Thank you, " + PlayerName + ", lets begin...");
      return PlayerName;
    }
  }
}