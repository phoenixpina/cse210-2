using System;

class Program
{
    static void Main(string[] args)
    {
        Falcon Joey = new Falcon("Joey", "Nyeh");
        Falcon Dragon = new Falcon("Dragon", "Barrel Rider!!!");

        Joey.MakeSound();
        Dragon.MakeSound();
        //Console.WriteLine($"Falcon's name is {Joey.GetName()}");
        //Console.WriteLine($"Falcon's name is {Dragon.GetName()}");
    }
}