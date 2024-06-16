public class ListingActivity : Activity
{
    private List<string> _listingPrompts;
    private List<string> _userLists;

    public ListingActivity() 
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Good job on listing things today!", 5)
    {
        _listingPrompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _userLists = new List<string>();
    }

    public void PerformListingActivity()
    {
        Loading();
        StartingActivity();
        Loading();
        DisplayListingPrompt();

        for (int i = 0; i < _duration; i++)
        {
            string answer = Console.ReadLine();
            _userLists.Add(answer);
        }

        Console.Clear();
        Console.WriteLine("Here are all the things you are grateful for.");
        Loading();
        DisplayUserLists();
        Loading();
        EndingActivity();
        Loading();
    }

    private void DisplayListingPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_listingPrompts.Count);
        Console.WriteLine(_listingPrompts[randomIndex]);
    }

    private void DisplayUserLists()
    {
        foreach (string answer in _userLists)
        {
            Console.WriteLine(answer);
        }
    }
}
