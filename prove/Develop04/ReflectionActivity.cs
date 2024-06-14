public class ReflectionActivity : Activity
{
    private List<string> _reflectionPrompts;
    private List<string> _reflectionQuestions;

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.", "Good job on reflectioning today!", 5)
    {
        _reflectionPrompts = new List<string> 
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _reflectionQuestions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void DisplayReflectionPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_reflectionPrompts.Count);
        string randomPrompt =_reflectionPrompts[randomIndex];

        Console.WriteLine(randomPrompt);
    }

    public void DisplayReflectionQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(_reflectionQuestions.Count);
        string randomQuestion = _reflectionQuestions[randomIndex];

        Console.WriteLine(randomQuestion);
    }

    public void PeformReflectionActivity()
    {
        Loading();
        Console.Clear();
        StartingActivity(_activityName, _startingMessage);
        Loading();

        DisplayReflectionPrompt();
        Console.WriteLine("As the questions appear, please enter in your thoughts.");

        for (int i = 0; i < _duration; i++)
        {
            DisplayReflectionQuestion();
            string answer = Console.ReadLine();
            Loading();
        }

        EndingActivity(_endingMessage);
        Loading();
        Console.Clear();
    }


}