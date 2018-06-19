using System.Collections.Generic;

namespace Frozen.Project
{
    public class Room : IRoom
    {
        //properties
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Item> Items { get; set; }
        public Dictionary<string, Room> Directions { get; set; }
        //constructor method
        public void move(string selection)
        {

        }
        public Room(string name, string description)
        {
            Name = name;
            Description = description;
            Items = new List<Item>();
            Directions = new Dictionary<string, Room>();
        }
        public Room Go(string direction)
        {
            if (Directions.ContainsKey(direction))
            {
                return Directions[direction];
            }
            return null;
        }

        public Item Takeitem(string item)
        {
            Item found = Items.Find(i => i.Name.ToLower() == item );
            if(found != null){
                return found;
            }
            return null;
        }
        public void addDirection(Room room, string direction)
        {
            Directions.Add(direction, room);
        }

        public void UseItem(Item item)
        {
            throw new System.NotImplementedException();
        }
    }
}