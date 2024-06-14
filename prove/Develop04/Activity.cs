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
    
    public void StartingActivity(string activityName, string startingMessage)
    {
        Console.WriteLine($"Welcome to the {activityName}!\n");
        Console.WriteLine(startingMessage);
    }

    public void EndingActivity(string endingMessage)
    {
        Console.WriteLine(endingMessage);
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
    }
}
