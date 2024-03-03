using System;
using System.Threading;
class ExcersizeActivity : Activity
{
    private readonly string[] ExcersizePrompts =
    {
        "Do a few pushups.",
        "Do a few sit-ups.",
        "Stretch out your legs, either standing up or sitting down.",
        "Lay on your back and stretch your body out horozontally with your arms above your head.",
        "Do a few crunches.",
        "Do a few squats.",
        "Do a few leg lifts.",
        "Stretch your arms and neck out a little.",
    };

    public void PerformExcersizeActivity()
    {
        StartMessage();
        Console.WriteLine(@"Instructions: Excersize is a good way to relieve stress. However,
        many people feel that excersize can be stressful. So, you will be given a prompt to do a simple
        excersize. Do as much of it as you desire in the time limit you set for yourself.");
        Animation();

        Console.WriteLine("Showing the random excersize prompt in 3...");
        Thread.Sleep(1000);
        Console.WriteLine("2...");
        Thread.Sleep(1000);
        Console.WriteLine("1...");
        Thread.Sleep(1000);
        var randomExcersizePrompt = ExcersizePrompts[new Random().Next(ExcersizePrompts.Length)];
        Console.WriteLine($"{randomExcersizePrompt}");
        Animation();

        EndMessage();
    }
}