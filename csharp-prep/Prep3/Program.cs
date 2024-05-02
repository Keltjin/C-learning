using System;

class Program
{
    static void Main(string[] args)
    {
        int guess;
        int guessNumber = 0;
        bool guessLoop = true;
        bool gameLoop = true;
        string play;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            Console.WriteLine("Welcome to the Number Guessing Game!\n");
        
            while (guessLoop == true)
            {
                guessNumber += 1;

                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    guessLoop = false;
                }
            }

            Console.WriteLine($"The amount of guesses is {guessNumber}.");
            Console.Write("Would you like to play again? ");
            play = Console.ReadLine();
            
            if (play.ToLower() == "no")
            {
                gameLoop = false;
            }
        } while (gameLoop != false);
    }
}