using System.Diagnostics;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {

    }

    public void WriteEntry()
    {
        Entry newEntry = new Entry();
        PromptGenerator prompt = new PromptGenerator();

        prompt.DisplayPrompts();
        newEntry._entry = Console.ReadLine();

        _entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveFile()
    {
        Console.WriteLine("Enter a name for the journal to be saved as with a .txt: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date}");
                outputFile.WriteLine($"Entry {entry._entry}");
                outputFile.WriteLine();
            }
        }
    }

    public void LoadFile()
    {
        Console.WriteLine("Enter the name of the journal file you are trying to access: ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    public void DisplayMenu()
    {
        bool programLoop = true;

        Console.WriteLine("\nWelcome to the Journal Program!\n");
        do
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load ");
            Console.WriteLine("5. Quit");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteEntry();
                    break;
                case "2":
                    DisplayEntries();
                    break;
                case "3":
                    SaveFile();
                    break;
                case "4":
                    LoadFile();
                    break;
                case "5":
                    Console.WriteLine("Exiting the program.");
                    programLoop = false;
                    break;
                default:
                    Console.WriteLine("Not a valid option!\n");
                    break;
            }

            
        } while (programLoop);
    }  
}