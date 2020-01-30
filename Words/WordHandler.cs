using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Words
{
    public static class WordHandler
    {
        //väli
        public static readonly string WordsFilePath = "/Users/katlinpaju/Desktop/HangmanSolution/Words/words.json";
        
        public static string GetRandomWord()
        {
            var words = LoadWordsFromFile();
            var random=new Random();
            return words[random.Next(0, words.Count)];
        }

       //listist sõnade saamine 
        public static List<string> LoadWordsFromFile()
        {
            var jsonString = System.IO.File.ReadAllText(WordsFilePath);
            return JsonSerializer.Deserialize<List<string>>(jsonString);
        }
    }
}