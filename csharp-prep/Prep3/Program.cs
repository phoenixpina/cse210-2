using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1,101);
        int guess = -1;

        while (guess != magicNumber) {
            Console.Write($"What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber) {
                Console.Write($"Guess lower. ");
            }

            else if (guess< magicNumber) {
                Console.Write($"Guess higher. ");
            }

            else {
                Console.Write($"You guessed correctly. ");
            }
        }
    }
}