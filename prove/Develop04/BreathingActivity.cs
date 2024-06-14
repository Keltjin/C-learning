public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly.", "Good job on breathing in and out slowly!", 5)
    {
    }

    public void PerformActivity()
    {
        Loading();
        Console.Clear();
        StartingActivity(_activityName, _startingMessage);
        for (int i = 0; i < _duration; i++)
        {
            Console.WriteLine("Breathe in...");
            System.Threading.Thread.Sleep(3000); // Sleep for 3 seconds
            Console.WriteLine("Breathe out...");
            System.Threading.Thread.Sleep(3000); // Sleep for 3 seconds
        }
        EndingActivity(_endingMessage);
        Loading();
        Console.Clear();
    }
}
