using System;

class Program
{
    static void Main(string[] args)
    {
        int userScore;
        char userGrade;

        Console.WriteLine("Welcome to your Pass or Fail Program!");

        Console.Write("\nPlease enter in a grade: ");
        userScore = int.Parse(Console.ReadLine());

        if (userScore >= 90)
        {
            userGrade = 'A';
        }

        else if (userScore >= 80)
        {
            userGrade = 'B';
        }

        else if (userScore >= 70)
        {
            userGrade = 'C';
        }

        else if (userScore >= 60)
        {
            userGrade = 'D';
        }

        else
        {
            userGrade = 'F';
        }

        Console.WriteLine($"\nYour grade is {userGrade}.");

        if (userScore >= 70)
        {
            Console.WriteLine("You have passed!");
        }

        else
        {
            Console.WriteLine("Try again next time.");
        }

    }
}