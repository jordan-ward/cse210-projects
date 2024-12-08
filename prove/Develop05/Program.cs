using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string userSelection = "";

        while(userSelection != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu selection:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Please enter the number for your selection: ");

            userSelection = Console.ReadLine();

            if (userSelection == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.StartActivity();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
            }

            else if (userSelection == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.StartActivity();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
            }

            else if (userSelection == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.StartActivity();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
            }
        }

        Console.WriteLine("Thank you!");
    }
}