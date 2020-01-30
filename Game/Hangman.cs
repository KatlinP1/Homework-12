namespace Game
{
    public static class Hangman
    {
        //https://gist.github.com/chrishorton/8510732aa9a80a03c829b09f12e20d9c hangman ASCII art
        public static string[] HangmanFigure = new[]
        {
            " \n\n\n\n\n\n=========",
            "  +---+\n      |\n      |\n      |\n      |\n      |\n=========",
            "  +---+\n  |   |\n      |\n      |\n      |\n      |\n=========",
            "  +---+\n  |   |\n  O   |\n      |\n      |\n      |\n=========",
            "  +---+\n  |   |\n  O   |\n  |   |\n      |\n      |\n=========",
            "  +---+\n  |   |\n  O   |\n /|   |\n      |\n      |\n=========",
            "  +---+\n  |   |\n  O   |\n /|\\  |\n      |\n      |\n=========",
            "  +---+\n  |   |\n  O   |\n /|\\  |\n /    |\n      |\n=========",
            "  +---+\n  |   |\n  O   |\n /|\\  |\n / \\  |\n      |\n========="
            
        };
    }
}