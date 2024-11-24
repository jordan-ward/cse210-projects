using System;

class Program
{
    static void Main(string[] args)
    {
        Reference citation = new Reference();
        citation._book = "Proverbs";
        citation._chapter = "3";
        citation._startVerse = "5";
        citation._endVerse = "6";

        Scripture scripture = new Scripture();
        scripture._words = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("");
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine($"{Reference.GetDisplayText} {Scripture.GetDisplayText}");
            Console.WriteLine("");
            Console.WriteLine("Please press enter to proceed. Or type 'quit' to finish.");
            string input = Console.ReadLine();

            Scripture.HideRandomWords;

            if (input.ToLower == "quit")
            {
                Console.WriteLine("Thanks for participating!");

            }
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Thanks for participating!");

            }
        }
    }
}