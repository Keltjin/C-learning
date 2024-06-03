using System;

class Program
{
    static void Main(string[] args)
    {
        // Define the scripture reference and text
        ScriptureReference reference = new ScriptureReference("3 Nephi", 5, 1);
        string text = "And now behold, there was not a living soul among all the people of the Nephites who did doubt in the least the words of all the holy prophets who had spoken; for they knew that it must needs be that they must be fulfilled.";

        // Create the Scripture object
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture);
                Console.WriteLine("\nAll words are hidden. The program will now exit.");
                break;
            }
        }
    }
}
