using System.Collections.Generic;

namespace Frozen.Project
{
    public class Player : IPlayer
    {
        public List<Item> Inventory { get; set; }
    
    public Player()
    {
        Inventory = new List<Item>();
        
    }
    
    }
}