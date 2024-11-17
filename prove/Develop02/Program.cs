using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();
        
        int choice = -1;

        do
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome to your Journal!");
            Console.WriteLine("Please select a number:");
            Console.WriteLine("1. Write a new entry.");
            Console.WriteLine("2. Display your journal.");
            Console.WriteLine("3. Save your journal.");
            Console.WriteLine("4. Load your journal.");
            Console.WriteLine("5. Exit.");
            Console.WriteLine("");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                DateTime todaysDate = DateTime.Today;
                string date = todaysDate.ToString("MM/dd/yyyy");

                string prompt = PromptGenerator.GetRandomPrompt();

                Console.WriteLine($"Today's date is {date}");
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Please make your entry for today: ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                journal.AddEntry(newEntry);
            }

            else if (choice == 2)
            {
                Journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("What would you like to name your file?: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
                Console.WriteLine("Saved successfully!");
            }
            
            else if (choice == 4)
            {
                Console.WriteLine("What is the name of the file that you would like to load?: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }

            else
            {
                break;
            }



        } while (choice != 5);

        Console.WriteLine("Thank you for participating!");
    }
}