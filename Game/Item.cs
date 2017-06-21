using System;
using System.Collections.Generic;

namespace CastleGrimtol.Game
{
  public class Item : IItem
  {
    public Dictionary<Room, string> Use = new Dictionary<Room, string>();///key is the room and it returns what happens which is the string!
    public string Name { get; set; }
    public string Description { get; set; }
    
    public Item(string name, string description)//pass interact as new param bool then if interactive, true and new options.
    {
      Name = name;
      Description = description;
    }

    public void Look()
    {
      Console.WriteLine(Description);
    }
  }
}