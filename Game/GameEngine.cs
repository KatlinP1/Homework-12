using System;
using Words;

namespace Game
{
    public class GameEngine
    {
        public static void RunGame()
        {
            var word = WordHandler.GetRandomWord();
            var game = new Game(word);
            while (game.GameState==GameState.INPROGRESS)
            {
                GameUI.PrintGame(game);
                var input = Console.ReadLine();
                
                //teeb stringist, mis kasutaja annab char'i
                if (char.TryParse(input, out var inputChar))
                {
                    game.MakeMove(inputChar);
                }

            }
            GameUI.PrintGame(game);
            Console.WriteLine();
            GameUI.PrintGameState(game);
            Console.ReadKey();
        }

        
        
    }
}