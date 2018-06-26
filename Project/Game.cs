using System;
using System.Collections.Generic;

namespace Frozen.Project
{
    public class Game : IGame
    {
        public Player CurrentPlayer { get; set; }
        //since it is a public class it iwll be a public get and set
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
                    // case "reset":
                    // setCurrentRoom(CurrentRoom.Directions["Setup"]);
                    // break;
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
                System.Console.WriteLine("Still up for an adventure? Simply move North(N) or South(S)?");
                System.Console.WriteLine("You could also 'Look' at any time to see if there is anything you may care to 'Take' and 'Use'.");

                string input = Console.ReadLine();
                string[] inputArray = input.Split(" ");
                switch (inputArray[0].ToLower())
                {
                    case "go":
                        Console.Clear();
                        if (inputArray.Length > 1)
                        {
                            move(inputArray[1]);
                        }
                        else
                        {
                            System.Console.WriteLine("That direction is not recognized");
                        }
                        //CurrentRoom = CurrentRoom.Go(inputArray[i] != null);
                        break;
                    case "move":
                        Console.Clear();
                        if (inputArray.Length > 1)
                        {
                            move(inputArray[1]);
                        }
                        else
                        {
                            System.Console.WriteLine("I don't go that direction");
                        }
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
                    case "reset":
                        Console.Clear();
                        Setup();
                        break;
                    case "notwin":
                        Console.Clear();
                        NotWin();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("invalid command");
                        break;
                }

            }

        }
        public void Setup()
        {
            Room room0 = new Room("Your Home", "You begin at home, as a kid..");
            Room room1 = new Room("Arrendale", "Surrounding you is a frozen tundra...");
            Room room2 = new Room("Elsa's Castle", "You have followed the icey steps up to a quiet castle");
            Room room3 = new Room(" The Ice Dance", "Now you are at an ice-dance, the center of attention!");
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
            Item takenItem = CurrentRoom.Takeitem(itemName);
            if (takenItem != null)
            {
                Console.WriteLine($"You have taken the {takenItem.Name}");
                CurrentPlayer.Inventory.Add(takenItem);
            }
            // {
            //     if (CurrentRoom.Name == "Elsa's Castle" && found.Name == "sleigh")
            //     {
            //         System.Console.WriteLine("Congratulations, you used the Sleigh to arrive at the Ice Dance on time, YOU Win! celebrate!!");
            //         playing = false;
            else
            {
                System.Console.WriteLine("That item was not found here");
            }

        }

        public void Help()
        {
            System.Console.WriteLine("You can choose from the following actions: go, reset, use, take, inventory, help, notwin or quit.");
        }
        public void NotWin()
        {
            System.Console.WriteLine("You Lose, Game Over.");
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
                } else 
                 if (CurrentRoom.Name == "Arrendale" && found.Name == "goblet")
                {
                    System.Console.WriteLine("Sorry, poisenous potion inside goblet, consumed, game over!.LOSE.");
                    playing = false;
                }
            }
        }

        public void Result(string winlose)
        {

        }
    }
}