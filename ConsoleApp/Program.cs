using System;
using Game;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("HANGMAN GAME!");
                Console.WriteLine("_________________________________");
                Console.WriteLine("Reegel: Arva mängus ära sõna. Võid eksida tähega 8 korda.");
                Console.WriteLine("_________________________________");
                Console.WriteLine("N uus mäng");
                Console.WriteLine("X välju mängust");
                Console.Write(">");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "n")
                {
                    GameEngine.RunGame();
                }
                else if (userInput == "x")
                {
                    break;
                }

            }

        }
    }
}