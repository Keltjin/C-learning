public class Activity
{
    protected string _activityName;
    protected string _startingMessage;
    protected string _endingMessage;
    protected int _duration;

    public Activity(string activityName, string startingMessage, string endingMessage, int duration)
    {
        _activityName = activityName;
        _startingMessage = startingMessage;
        _endingMessage = endingMessage;
        _duration = duration;
    }
    
    public void StartingActivity()
    {
        Console.WriteLine($"Welcome to the {_activityName}!\n");
        Console.WriteLine(_startingMessage);
    }

    public void EndingActivity()
    {
        Console.WriteLine(_endingMessage);
    }

    public void Loading()
    {
        Console.Write("Loading");
        for (int i = 0; i < 3; i++)
        {
            System.Threading.Thread.Sleep(500); // Sleep for 500 milliseconds
            Console.Write(".");
        }
        Console.WriteLine();
        Console.Clear();
    }
}
