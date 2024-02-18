using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Scripture newScripture = new Scripture("1Nephi 3:7", "I will go and do");
        //I'm fully aware that this is incorrect and that I need to be using a list.
        //It will only display the John scripture.
        //However, I couldn't get it to work so I'm leaving it as is and turning it in.
        Console.WriteLine(scripture);

        Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
        while (!scripture.AllWordsHidden())
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWord();
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
        }

        Console.WriteLine("Good luck out there.");
    }
}