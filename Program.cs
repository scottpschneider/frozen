using System;
using Frozen.Project;

namespace Frozen.Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            game.Setup();
            Console.Clear();
            System.Console.WriteLine($"Welcome to the Frozen game, you are in {game.CurrentRoom.Name}");
            game.Play();
            bool inRoom = true;
            while (inRoom)
            {
                System.Console.WriteLine("go north or south?");
                string selection = Console.ReadLine();
                game.move(selection);
            }
        }
    }
}

