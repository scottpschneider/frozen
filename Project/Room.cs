using System.Collections.Generic;

namespace Frozen.Project
{
    public class Room : IRoom
    {
        //properties
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Item> Items { get; set; }
        public Dictionary<string, Room> Directions {get; set;}
        //constructor method
        public void move(string selection){
            bool valid = true; 
            while(valid);
        }
        public Room(string name, string description)
        {
            Name = name; 
            Description = description;
            var Room = new List<Room>();
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