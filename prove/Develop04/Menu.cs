using System;
using System.Collections.Generic;

public class Menu 
{
    private Activity _activity;
    private BreathingActivity _breathingActivity;
    private ReflectionActivity _reflectionActivity;
    private ListingActivity _listingActivity;

    public Menu()
    {
        _activity = new Activity("", "", "", 0);
        _breathingActivity = new BreathingActivity();
        _reflectionActivity = new ReflectionActivity();
        _listingActivity = new ListingActivity();
    }

    public void DisplayMenu()
    {
        _activity.Loading();
        Console.WriteLine("Welcome to the Breathing program!");

        List<string> menuOptions = new List<string>
        {
            "\t1. Breathing Activity.",
            "\t2. Reflecting Activity.",
            "\t3. Listing Activity.",
            "\t4. Quit."
        };

        bool menuLoop = true;

        while (menuLoop)
        {
            Console.WriteLine("Please enter a number to start an activity.");
            DisplayOptions(menuOptions);

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    _breathingActivity.PerformBreathingActivity();
                    break;
                case "2":
                    _reflectionActivity.PerformReflectionActivity();
                    break;
                case "3":
                    _listingActivity.PerformListingActivity();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Goodbye.");
                    _activity.Loading();
                    menuLoop = false;
                    break;
                default:
                    HandleInvalidChoice(choice);
                    break;
            }
        }
    }

    private void DisplayOptions(List<string> options)
    {
        foreach (string option in options)
        {
            Console.WriteLine(option);
        }
    }

    private void HandleInvalidChoice(string choice)
    {
        Console.Clear();
        Console.WriteLine($"\"{choice}\" is not a valid option");
        _activity.Loading();
    }
}
