using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        bool showMenu = true;
        while (showMenu)
        {
            showMenu = Menu();
        }
    }

    private static bool Menu()
    {
        Console.Clear();
        Console.WriteLine("This is a program with 4 quick and easy stress relieving activities.");
        Console.WriteLine("Type a number to run one of the stress relieving activities:");
        Console.WriteLine("1: Breathing Activity");
        Console.WriteLine("2: Reflection Activity");
        Console.WriteLine("3: Listing Activity");
        Console.WriteLine("4: Simple Excersize Activity");
        Console.WriteLine("5: Quit");
        Console.WriteLine("\n Type number here: ");
        string userInput = Console.ReadLine();

        switch(userInput)
        {
            case "1":
            Console.WriteLine("Starting Breathing Activity:");
            BreathingActivity breathing = new BreathingActivity();
            breathing.PerformActivity();
            breathing.PerformBreathingActivity();
            //break; //(necessary?)
            Console.ReadLine();
            return true;

            case "2":
            Console.WriteLine("Starting Reflection Activity:");
            ReflectionActivity reflection = new ReflectionActivity();
            reflection.PerformActivity();
            reflection.PerformReflectionActivity();
            Console.ReadLine(); 
            return true;

            case "3":
            Console.WriteLine("Starting Listing Activity:");
            var listing = new ListingActivity();
            listing.PerformActivity();
            listing.PerformListingActivity();      
            Console.ReadLine();
            return true;

            case "4":
            Console.WriteLine("Starting the Simple Excersize Activity:");
            var excersize = new ExcersizeActivity();
            excersize.PerformActivity();
            excersize.PerformExcersizeActivity();
            Console.ReadLine();
            return true;

            case "5":
            Console.Clear();
            Console.WriteLine("Good luck out there!");
            System.Environment.Exit(0); //ends program
            return false;

            default:
            Console.WriteLine("Invalid option. Please only type a number from 1 to 5.");
            Console.ReadLine();
            return true; 
        }
    }
}