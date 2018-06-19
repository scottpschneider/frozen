using System.Collections.Generic;

namespace Frozen.Project
{
    public class Player : IPlayer
    {
        public List<Item> Inventory { get; set; }
    
    public Player(string score, List<Item> inventory)
    {
        Inventory = inventory;
    }
    
    }
}