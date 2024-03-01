using System;
using System.Threading;
class Activity
{
    public int Duration{ get; set; } //Duration of timer in seconds
    public static void StartMessage()
    {
        Console.WriteLine("Please relax. These activities are meant to help calm you down and help clear your mind.");
        Console.WriteLine("");
    }
    public static void EndMessage()
    {
        Console.WriteLine("Good job! Press the Enter key to return to the menu.");
    }
    public static void Animation()
    {
        string[] symbols = { "|", "/", "-", "/" }; // Define the symbols
        int symbolIndex = 0; // Initialize the index for the current symbol

        for (int i = 0; i < 17; i++)
        {
        Console.Write(symbols[symbolIndex]); // Print the current symbol
        Thread.Sleep(500); // Pause for half a second
        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); // Move the cursor back
        symbolIndex = (symbolIndex + 1) % symbols.Length; // Update the symbol index
        }
        Console.WriteLine(); // Move to the next line
    }

    public void PerformActivity()
    {
        Console.Write("Enter how long you want the activity to last (in seconds): ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Duration = duration;
        }
        else
        {
            Console.WriteLine("Invalid input. Using default duration of 20 seconds instead.");
            Duration = 20; 
        }
        Console.Clear();
    }
}