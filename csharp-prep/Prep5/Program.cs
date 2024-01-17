using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber); //this bit confuses me. I don't know what parameters to put in

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Write a number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)  //why is this static? I thought static meant it didn't need outside stuff
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, your number is {number}. ");
    }
}