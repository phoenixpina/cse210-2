using System;
//using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber != 0) {
            Console.Write("Enter a number. Enter 0 to quit. ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0) {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach(int number in numbers) {
            sum += number;
        }

        //float average = float.Parse(sum) / numbers.Count;
        float sum2 = (float)sum;
        float average = sum2 / numbers.Count;

        int max = numbers[0];
        foreach (int number in numbers) {
            if (number > max) {
                max = number;
            }
        }
        Console.Write($"The sum is {sum}. ");
        Console.Write($"The average is {average}. ");
        Console.Write($"The highest number is {max}. ");
    }
}