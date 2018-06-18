using System;
using System.Collections.Generic;

namespace Frozen.Project
{
    public class Game : IGame
    {
        public List<Room> Rooms = new List<Room>();
        public Room CurrentRoom { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public Player CurrentPlayer { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }
    
        public void move(string selection)
        {
            
            bool valid = true;
            while (valid);
            switch (selection)
      {
          case "North":
          case "N":
              setCurrentRoom(CurrentRoom.Directions["North"]);
              break;
          case "South":
          case "S":
              setCurrentRoom(CurrentRoom.Directions["South"]);
              break;
          default:
              Console.WriteLine("I don't recognize that direction.");
              break;
      }
        }
        //must initialize rooms bfore 
        public void Setup()
        {
            Room room0 = new Room("Home", "you begin at home, as a kid..");
            Room room1 = new Room("Arrendale", "you arrive in a frozen tundra...");
            Room room2 = new Room("Elsa's Castle", "you follow the icey steps up to a quiet castle");
            Room room3 = new Room("Ice Dance", "you are now at the ice-dance, the center of attention!");
            room1.addDirection( room2, "North");
            room2.addDirection( room1, "South");
            Rooms.Add(room1);
            setCurrentRoom(room0);
        }

        public void UseItem(string itemName)
        {
            throw new System.NotImplementedException();
        }
        public void setCurrentRoom(Room room){
            CurrentRoom = room;
        }
    }
}