using System;
using Frozen.Project;

namespace Frozen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            game.Setup();
            Console.Clear();
            System.Console.WriteLine($"Welcome to the game, you are in {game.CurrentRoom.Name}");
            bool inRoom = true;
            while (inRoom) {
            System.Console.WriteLine("Which direction would you like to go?");
            string selection = Console.ReadLine();
            game.move(selection);
            }
        }
        }
    }

