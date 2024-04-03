using System;

class AnimalProgram
{
    static void AnimalMain(string[] args) //the sandbox folder can only have one "Program" and "Main" somewhere
    {
        Falcon Joey = new Falcon("Joey", "Nyeh");
        Falcon Dragon = new Falcon("Dragon", "Barrel Rider!!!");

        Joey.MakeSound();
        Dragon.MakeSound();
        //Console.WriteLine($"Falcon's name is {Joey.GetName()}");
        //Console.WriteLine($"Falcon's name is {Dragon.GetName()}");
    }
}