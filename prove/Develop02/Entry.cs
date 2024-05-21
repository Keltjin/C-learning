public class Entry
{
    public string _entry;
    public string _date;

    public Entry()
    {
        _date = GetCurrentDate();
    }

    public string GetCurrentDate()
    {
        DateTime currentDate = DateTime.Today;
        string formattedDate = currentDate.ToString("MM-dd-yyyy");
        
        return formattedDate;
    }

    public void DisplayEntry()
    {
        string date = GetCurrentDate();
        Console.WriteLine($"Date: {date}");
        Console.WriteLine($"Entry: {_entry}");
        Console.WriteLine();
    }
}