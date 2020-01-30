using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using Console = Colorful.Console;

namespace Game
{
    public class Game
    {
        //propertid
        public string Word { get; set; }
        public int Moves { get; set; } = 0;
        public char[] Letters;
        public List<char> LetterRight { get; set; } = new List<char>();
        public List<char> LetterWrong { get; set; } = new List<char>();
        public GameState GameState { get; set; }

        public Game(string word)
        {
            Word = word;
            Letters = new char[word.Length];
            GameState = GameState.INPROGRESS;
        }

        public bool MakeMove(char input)
        {
            //kontrollib, kas kasutaja sisestus on üldse täht
            if (!CheckCharacter(input))
            {
                return false;
            }
            
            //kontrollib, kas sõnas on kasutaja pakutud täht
            if (Word.Contains(input))
            {
                int i = 0;
                foreach (char letter in Word)
                {
                    if (letter==input)
                    {
                        Letters[i] = letter;
                    }

                    i++;
                    
                }
                LetterRight.Add(input);
            }
            else
            {
                LetterWrong.Add(input);
            }

            Moves++;
            CheckGameState();
            return true;
        }

        public bool CheckCharacter(char letter)
        {
            //kontorllib, et sisetatud asi oleks täht, mitte nt number
            if (!char.IsLetter(letter))
            {
                return false;
            }

            //kontrollib, et sama tähte ei sisestataks mitu korda
            if (LetterRight.Contains(letter) || LetterWrong.Contains(letter))
            {
                return false;
            }
            return true;
        }

        //kontrollib, kas mäng jätkub, või on lõppenud
        public void CheckGameState()
        {
            var count = 0;
            foreach (char letter in Letters)
            {
                if (letter == '\0')
                {
                    count++;
                }
            }

            if (count == 0)
            {
                GameState = GameState.WON;
            }
            else if ( LetterWrong.Count== 8)
            {
                GameState = GameState.LOST;
            }


        }
        

    }
    
}