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
            System.Console.WriteLine($"Welcome to the game, you are in {game.CurrentRoom.Name}");
            game.Play();
            bool inRoom = true;
            while (inRoom)
            {
                System.Console.WriteLine("Would you like to go North(N) or South(S)?");
                string selection = Console.ReadLine();
                game.move(selection);
            }
        }
    }
}

