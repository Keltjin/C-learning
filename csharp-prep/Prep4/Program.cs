using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        float average;
        int sum = 0;
        int max = 0;
        bool loop = true;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                loop = false;
            }
        }while(loop == true);

        foreach(int num in numbers)
        {
            sum += num;

            if (num > max)
            {
                max = num;
            }
        };

        average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}.");
        Console.WriteLine($"The average is: {average}.");
        Console.WriteLine($"The largest number is: {max}.");
    }
}