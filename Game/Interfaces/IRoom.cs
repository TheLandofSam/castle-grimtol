using System.Collections.Generic;

namespace CastleGrimtol.Game
{
    public interface IRoom
    {
        string Name { get; set; }
        string Description { get; set; }
        List<Item> Items { get; set; }//might be empty, or might have items.closets.items.add()
    

        void UseItem(Item item);

        

    }
}