using System;

class Program
{
    static void Main(string[] args)
    {
        string userName;
        int userNumber;
        int square;

        DisplayWelcome();
        userName = PromptUserName();
        userNumber = PromptUserNumber();
        square = SquareNumber(userNumber);
        DisplayResult(userName, square);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        string name;

        Console.Write("Please enter your name: ");
        name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        int number;

        Console.Write("Please enter your favorite number: ");
        number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int userNumber)
    {
        int square = userNumber * userNumber;

        return square;
    }

    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}.");
    }
}