using System;
using System.Threading;

class BreathingActivity : Activity
{
    public void PerformBreathingActivity() //needs parameters maybe
    {
        StartMessage();
        Console.WriteLine(@"Instructions: You will be taking deep breaths. 
        There will be 3 second pauses in between breathing in and out.");
        Animation(); 
        Console.WriteLine("We will now begin. Breathe in...");
        Thread.Sleep(3000);
        Console.WriteLine("Breathe out slowly...");
        Thread.Sleep(3000);

        // Repeats cycle for the specified duration
        var endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(3000); 

            Console.WriteLine("Breathe out...");
            Thread.Sleep(3000); 
        }

        EndMessage();
    }
}