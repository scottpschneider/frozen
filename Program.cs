using System;
using Frozen.Project;

namespace Frozen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game Game = new Game();
            System.Console.WriteLine("Welcome to the game, you are in Room 1");
            bool inRoom = true;
            while (inRoom) {
            System.Console.WriteLine("Which direction would you like to go?");
            string selection = Console.ReadLine();
            
            Game.move(selection);
            }
        }
        }
    }

