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
            System.Console.WriteLine($"Welcome to FROZEN, you begin at {game.CurrentRoom.Name}");
            game.Play();
            bool inRoom = true;
            while (inRoom)
            {
                System.Console.WriteLine("Game Over");
                string selection = Console.ReadLine();
                game.move(selection);
            }
        }
    }
}

