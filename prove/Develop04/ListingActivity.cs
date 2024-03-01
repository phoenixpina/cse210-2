using System;
using System.Threading;
using System.Collections.Generic;
class ListingActivity : Activity 
{
    private List<string> userItems = new List<string>();

    private readonly string[] Prompts = 
    {
    "Name works of art you like (games, books, movies, paintings, songs, etc.)",
    "Name some people you are grateful for.",
    "What's some places you'd like to visit?",
    "List some good things you did this week.",
    "List some good food you ate this week.",
    };

    public void PerformListingActivity()
    {
        StartMessage();
        Console.WriteLine(@"Instructions: You will be given a prompt.
        After a few seconds of thinking, list as many items/answers as you desire in the time limit you set.
        Press the Enter key after each response.");
        var randomPrompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {randomPrompt}");
        Animation();

        var endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Type in answers: ");
            string userInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userInput))
            {
                userItems.Add(userInput);
            }
        }

        //Displays user's items back in the console
        Console.Clear();
        Console.WriteLine("\nUser items:");
        foreach (var item in userItems)
        {
            Console.WriteLine(item);
        }

        EndMessage();
    }
    private string GetRandomPrompt() //Method used right underneath instructions
    {
        return Prompts[new Random().Next(Prompts.Length)];
    }
}