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
                return Directions(direction);
                currentRoom.description
        return exits[direction]
        {
                return null;
            }
        }

        public Item Takeitem(Item item)
        {
            Items.Find(i => i.Name.ToLower() = item)
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