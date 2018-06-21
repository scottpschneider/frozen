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
            playing = true;
        }

        public void move(string selection)
        {

            switch (selection.ToLower())
            {
                case "north":
                case "n":
                    setCurrentRoom(CurrentRoom.Directions["north"]);
                    //  Here i want to display Room.room
                    break;
                case "south":
                case "s":
                    setCurrentRoom(CurrentRoom.Directions["south"]);
                    break;
                default:
                    Console.WriteLine("Whoops, slipped into a snow bank, cannot go that way!!");
                    Console.WriteLine("I don't recognize that direction.");
                    break;
            }
        }
        public bool playing = true;
        public void Play()
        {
            while (playing)
            {
                System.Console.WriteLine("Still up for an adventure? 'go' North(N) or South(S)?");
                System.Console.WriteLine("You could also 'Look' at any time to see if there is anything you may care to 'Take' and 'Use'.");

                string input = Console.ReadLine();
                string[] inputArray = input.Split(" ");
                switch (inputArray[0].ToLower())
                {
                    case "go":
                        Console.Clear();
                        move(inputArray[1]);
                        //CurrentRoom = CurrentRoom.Go(inputArray[i] != null);
                        break;
                    case "use":
                        Console.Clear();
                        UseItem(inputArray[1]);
                        break;
                    case "take":
                        Console.Clear();
                        TakeItem(inputArray[1]);
                        break;
                    case "help":
                        Console.Clear();
                        Help();
                        break;
                    case "look":
                        Console.Clear();
                        Look();
                        break;
                    case "quit":
                        Console.Clear();
                        Quit();
                        break;
                    case "inventory":
                        Console.Clear();
                        PrintInventory();
                        break;
                    case "Reset":
                        Console.Clear();
                        Play();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("invalid command");
                        break;
                }

            }
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
            Room room0 = new Room("Your Home", "You begin at home, as a kid..");
            Room room1 = new Room("Arrendale", "Surrounding you is a frozen tundra...");
            Room room2 = new Room("Elsa's Castle", "You have followed the icey steps up to a quiet castle");
            Room room3 = new Room(" The Ice Dance", "Now you are at an ice-dance, the center of attention!");
            // room1.exits.Add("north", room2);
            // room2.exits.Add("south", room1);
            room0.addDirection(room1, "north");
            room0.addDirection(room3, "south");
            room1.addDirection(room2, "north");
            room1.addDirection(room0, "south");
            room2.addDirection(room3, "north");
            room2.addDirection(room1, "south");
            room3.addDirection(room0, "north");
            room3.addDirection(room2, "south");
            Rooms.Add(room0);
            Rooms.Add(room1);
            Rooms.Add(room2);
            Rooms.Add(room3);
            setCurrentRoom(room0);
            Item item1 = new Item("icicle", "ahh, A thing of beauty!!");
            Item item2 = new Item("goblet", "Ooh, a Golden Goblet!");
            Item item3 = new Item("sleigh", "Yes perhaps this sleigh will help me get out of the castle, and to the dance on time!");
            Item item4 = new Item("walkingStick", "Well this looks handy, try not to impale any snowmen..hehe");
            room0.Items.Add(item1);
            room1.Items.Add(item2);
            room2.Items.Add(item3);
            room3.Items.Add(item4);
            CurrentRoom = room0;
            CurrentPlayer = new Player();
        }
        public void TakeItem(string itemName)
        {
            //Item.items.find(itemName);
            //need to call TakeItem function from room.cs line 33
            Item takenItem = CurrentRoom.Takeitem(itemName);
            if (takenItem != null)
            {
                Console.WriteLine($"You have taken the {takenItem.Name}");
                CurrentPlayer.Inventory.Add(takenItem);
            }
            else
            {
                System.Console.WriteLine("That item was not found here");
            }

        }

        public void Help()
        {
            System.Console.WriteLine("You can choose from the following actions: go, use, take, help, or quit.");
        }
        public void Quit()
        {
            playing = false;
        }
        public void setCurrentRoom(Room room)
        {
            CurrentRoom = room;
            System.Console.WriteLine($"You arrive in {CurrentRoom.Name}");
        }
        public void Look()
        {
            System.Console.WriteLine($"{CurrentRoom.Description}");
            System.Console.WriteLine("Items here: ");
            CurrentRoom.Items.ForEach(item =>
            {
                //change color to items
                System.Console.WriteLine(item.Name);
            });
        }

        public void PrintInventory()
        {
            System.Console.WriteLine("In your current inventory:");
            CurrentPlayer.Inventory.ForEach(item =>
            {
                System.Console.WriteLine(item.Name + ": " + item.Description);
            });
        }

        public void UseItem(string itemName)
        {
            System.Console.WriteLine($"you are using the {itemName} gracefully");
            // if (UseItem != null){
            // }
            Item found = CurrentPlayer.Inventory.Find(i => i.Name.Contains(itemName));
            if (found != null)
            {
                if (CurrentRoom.Name == "Elsa's Castle" && found.Name == "sleigh")
                {
                    System.Console.WriteLine("Congratulations, you used the Sleigh to arrive at the Ice Dance on time, YOU Win! celebrate!!");
                    playing = false;
                   // System.Console.WriteLine("you may move on to greener pastures, or choose reset to play again. ");
                }
            }
        }

        public void Result(string winlose)
        {

        }
    }
}