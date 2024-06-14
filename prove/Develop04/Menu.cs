using System;
using System.Collections.Generic;

public class Menu 
{
    private Activity _activity;
    private BreathingActivity _breathingActivity;
    private ReflectionActivity _reflectionActivity;

    public Menu()
    {
        _activity = new Activity("", "", "", 0);
        _breathingActivity = new BreathingActivity();
        _reflectionActivity = new ReflectionActivity();
    }

    public void DisplayMenu()
    {
        _activity.Loading();
        Console.Clear();

        Console.WriteLine("Welcome to the Breathing program!");
        
        List<string> menuOptions = new List<string>
        {
            "\t1. Breathing Activity.",
            "\t2. Reflecting Activity.",
            "\t3. Listing Activity.",
            "\t4. Quit.",
        };

        bool menuLoop = true;

        do
        {
            Console.WriteLine("Please enter a number to start an activity.");

            foreach (string option in menuOptions)
            {
                Console.WriteLine(option);
            }

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    _breathingActivity.PerformActivity();
                    break;
                case "2":
                    Console.Clear();
                    _reflectionActivity.PeformReflectionActivity();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Listing Activity is not available.");
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Goodbye.");
                    _activity.Loading();
                    menuLoop = false;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine($"\"{choice}\" is not a valid option");
                    _activity.Loading();
                    break;
            }
            
            Console.Clear();
        } while (menuLoop);
    }
}
