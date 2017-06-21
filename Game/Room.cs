using System;
using System.Collections.Generic;

namespace CastleGrimtol.Game
{
  public class Room : IRoom
  {
    public Dictionary<string, Room> Exits = new Dictionary<string, Room>();
    public string Name { get; set; }
    public string Description { get; set; }
    public Room Stairs { get; set; }
    public Room LockedDoorA { get; set; }
    public Room LockedDoorB { get; set; }
    public string Description1;
    public string Description2;
    public string Description3;
    public List<Item> Items { get; set; }

    public bool Locked;




    public void DEBUG()
    {
      foreach(var s in Exits){
        Console.WriteLine("Exit "+ s.Key + ": " + s.Value.Name);
      }
    }



    public Room(string name, string description)//pass interact as new param bool then if interactive, true and new options.
    {
      Name = name;
      Description = description;
      Items = new List<Item>();
    }

    public Room(string name, string description, Room stairs)
    {
      Name = name;
      Description = description;
      Items = new List<Item>();
      Stairs = stairs;
    }

       public Room(string name, string description1, string description2, string description3)//THIS IS SPECIFICALLY FOR THE END ROOM WHERE THE GAME IS WON WITH FULL SCORE THIS IS THE END OF THE GAME. NO RETURN FROM THIS ROOM
    {
      Name = name;
      Description1 = description1;
      Description2 = description2;
      Description3 = description3;
      Locked = false;
      Items = new List<Item>();
    }

    public void AddRoom(string direction, Room room)//problem here...
    {
      Exits.Add(direction, room);
      //room.Exits.Add//need to make a method that calculates the opposite of the direction above
    }
    public void Look()
    {
      Console.WriteLine(Description);
    }

    public bool IsLocked()
    {
      return Locked;
    }

    public void CantEnter()
    {
      Console.WriteLine(""); //LockedDescription
    }
    public void UseItem(Item item)
    {
      //fx from gamme page here....
      Locked = false;
      Console.WriteLine(Description);
    }


  }//room needs to have a list of usable items rather than the items having a list of usable rooms.
}//need to have a room use function that says if the door is locked look into player inventory for the matching key, if there flip the bool and display unlocked discription.

// void IRoom.UseItem(Item itemName)//or string itemName???
// {
//  //currentRoom.useItem[flashlight] this should go into the room, not here...

//   Item result = CurrentPlayer.Inventory.Find(strawberry => strawberry.Name == itemName);

//   if(result != null)
//   {
//     string Action = result.Use[game.CurrentRoom];
//     if(Action != null)
//     {
//         Console.WriteLine(Action);
//     }
//     else{
//         Console.Write("You cannot do that here.");
//     }

//   }
//   else
//   {
//     Console.WriteLine("You do not have the necessary item.");
//   }
//   GetUserAction();
// }
//   Locked = false;
//   Console.WriteLine(Description);
// }