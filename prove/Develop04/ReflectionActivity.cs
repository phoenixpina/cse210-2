using System;
using System.Threading;

class ReflectionActivity : Activity
{
    private readonly string[] FirstPrompts = 
    { 
        "Think about something you learned this week.", 
        "Think about a conversation you had with someone this week.", 
        "Think about a game you played this week. It can be any kind of game.",
        "Think about a song you recently listened to that stuck out to you.",
        "Think about a type of physical excersize you did this week.",
        "Think about a show or movie you've seen this week.",
    };
    private readonly string[] SecondPrompts = 
    { 
        "What did you learn or gain from it?", 
        "How did it make you feel?", 
        "How did it improve your week?",
        "Why did you enjoy it?",
        "What does it make you want to do that is positive?", 
    };

    public void PerformReflectionActivity()
    {
        StartMessage();
        Console.WriteLine(@"Instructions: You will be given an experience to remember. 
        Then, you will be given multiple questions about that experience to reflect about.");
        Animation();

        var randomFirstPrompt = FirstPrompts[new Random().Next(FirstPrompts.Length)];
        Console.WriteLine($"{randomFirstPrompt}");
        Animation();

        //Loops the second prompt type until the specified duration
        var endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            var randomSecondPrompt = SecondPrompts[new Random().Next(SecondPrompts.Length)];
            Console.WriteLine($"{randomSecondPrompt}");
            Animation();
        }

        EndMessage();
    }
}