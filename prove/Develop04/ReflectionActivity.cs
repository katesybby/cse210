using System;

public class ReflectionActivity : Activity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = {
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

    public ReflectionActivity() : base("REFLECTION ACTIVITY", "Reflect on times of strength and resilience") { }

    public override void Start()
    {
        base.DisplayStartingMessage();   //code stops here. the next lines dont run
        Reflect();
        base.DisplayEndingMessage();
        base.ReturnToMenu();
    }

    private void Reflect()
    {
        Console.WriteLine("\nConsider the following prompt:\n");

        string randomPrompt = _prompts[new Random().Next(_prompts.Length)];
        Console.WriteLine($"--- {randomPrompt} ---");

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder each of the following quesitons as they related to this experience.");
        Countdown();

        Console.Clear();

        DateTime startTime = DateTime.Now;
        TimeSpan duration = TimeSpan.FromSeconds(_userDuration);
        DateTime endTime = startTime.Add(duration);

        foreach (var question in _questions)
        {
            if (DateTime.Now >= endTime)
                break;

            Console.Write($"> {question}");
            ShowSpinner(7000);
            Console.WriteLine();
        }
    }
}