public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public Random random = new Random();

    public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person I interacted with today? ");
        _prompts.Add("What was the best part of my day? ");
        _prompts.Add("How did I see the hand of the Lord in my life today? ");
        _prompts.Add("What was the strongest emotion I felt today? ");
        _prompts.Add("If I had one thing I could do over today, what would it be? ");
        _prompts.Add("What is an act of service I did today? ");
        _prompts.Add("What was the funniest thing that happened today? ");
    }

    public string GetRandomPrompt()
    {
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }

    public void DisplayPrompts()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }
}