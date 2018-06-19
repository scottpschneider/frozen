using System;
using System.Collections.Generic;

namespace Frozen.Project
{
    public class Game : IGame
    {
        public Player CurrentPlayer { get; set; }
        public List<Room> Rooms = new List<Room>();
        public Room CurrentRoom { get; set; }
        // public List

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public void move(string selection)
        {

            switch (selection.ToLower())
            {
                case "north":
                case "n":
                    setCurrentRoom(CurrentRoom.Directions["North"]);
                    //  Here i want to display Room.room
                    break;
                case "south":
                case "s":
                    setCurrentRoom(CurrentRoom.Directions["South"]);
                    break;
                default:
                    Console.WriteLine("I don't recognize that direction.");
                    break;
            }
        }
           public bool playing = true;
        public void Play()
        {
            while (playing)
            {
                System.Console.WriteLine("Would you like to go North(N) or South(S)?");
                            
            string input = Console.ReadLine();
            string[] inputArray = input.Split(" ");
            switch (inputArray[0].ToLower())
            {
                case "go":
                    move(inputArray[1]);
                    break;
                case "Use":
                    UseItem(inputArray[1]);
                    break;
                case "Take":
                    TakeItem(inputArray[1]);
                    break;
                case "Help":
                    Help();
                    break;
                case "Quit":
                    Quit();
                    break;
                   
                    default: 
                    Console.WriteLine("invalid command");
                    break;
            }      
            }
            {

            }
            //     CurrentRoom = CurrentRoom.move(input[i] != null );
            // }
            // else
            // {
            //     Console.WriteLine("Whoops, slipped into a snow bank, cannot go that way!!");
            // }
            // {
            // take user input
            // input.split(")
            // switch input[0]
            
            // CurrentRoom = CurrentRoom.Go(imput[1] does not equal null)
            // else {System.Console.WriteLine("Whoops no way")};
            // }
            //must initialize rooms bfore 
        }
        public void Setup()
        {
            Room room0 = new Room("Your Home", "you begin at home, as a kid..");
            Room room1 = new Room("Arrendale", "you arrive in a frozen tundra...");
            Room room2 = new Room("Elsa's Castle", "you follow the icey steps up to a quiet castle");
            Room room3 = new Room(" The Ice Dance", "you are now at the ice-dance, the center of attention!");
            // room1.exits.Add("north", room2);
            // room2.exits.Add("south", room1);
            room0.addDirection(room1, "north");
            room1.addDirection(room2, "north");
            room2.addDirection(room3, "north");
            room3.addDirection(room0, "north");
            room0.addDirection(room1, "south");
            room1.addDirection(room2, "south");
            room2.addDirection(room3, "south");
            room3.addDirection(room0, "south");
            Rooms.Add(room0);
            Rooms.Add(room1);
            Rooms.Add(room2);
            Rooms.Add(room3);
            setCurrentRoom(room0);
            Item item1 = new Item("Icicle", "You have picked up an icicle");
            Item item2 = new Item("Goblet", "Ooh, a Golden Goblet!");
            Item item3 = new Item("Walking Stick", "Well this looks handy, try not to impale any snowmen..hehe");
            Item item4 = new Item("Large Sleigh", "Gosh this sleigh will be a great mode of transportation!");
            room0.Items.Add(item1);
            room1.Items.Add(item2);
            room2.Items.Add(item3);
            room3.Items.Add(item4);
            CurrentRoom = room0;
        }

        public void UseItem(string itemName)
        {
            throw new System.NotImplementedException();
        }
        public void TakeItem(string itemName)
        {
            TakeItem(itemName);
            //need to call TakeItem function from room.cs line 33
            System.Console.WriteLine($"You have taken the {""}");
        }
        public void Help()
        {
            System.Console.WriteLine("You must move");
        }
        public void Quit()
        {
            playing = false;
        }
        public void setCurrentRoom(Room room)
        {
            CurrentRoom = room;
        }

    }
}