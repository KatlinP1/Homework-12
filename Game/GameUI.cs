using System;
using System.Drawing;
using Console = Colorful.Console;

namespace Game
{
    public static class GameUI
    {
        public static void PrintGame(Game game)
        {
            Console.Clear();
            //kujutis
            Console.WriteLine(Hangman.HangmanFigure[game.LetterWrong.Count]);
            Console.WriteLine("Arva ära antud sõna: ");
            Console.WriteLine();
            //mänguvälja printimine 
            foreach (char letter in game.Letters)
            {
                if (letter == '\0')
                {
                    Console.Write("_ ");
                }
                else
                {
                    Console.Write(letter + " ");
                }
            }

            PrintUsedLetters(game);
            
            Console.WriteLine();
            Console.Write("> ");
            
        }

        public static void PrintUsedLetters(Game game)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Kasutatud tähtede loetelu: ");
            foreach (var x in game.LetterRight)
            {
                Console.Write(x + " ", Color.FromArgb(0, 128, 43));
            }
            
            foreach (var x in game.LetterWrong)
            {
                Console.Write(x + " ", Color.Red);
            }
        }

        public static void PrintGameState(Game game)
        {
            if (game.GameState==GameState.WON)
            {
                
                Console.WriteLine("Võitsid mängu! :)", Color.FromArgb(60, 190, 60));
            }
            else if (game.GameState==GameState.LOST)
            {
                
                Console.WriteLine("Kaotasid mängu.....", Color.Red);
                Console.WriteLine($"Õige sõna: {game.Word}");
            }
            
        }
        
    }
}