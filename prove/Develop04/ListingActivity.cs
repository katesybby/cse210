using System;

public class ListingActivity : Activity
{
    private List<string> _userResponses = new List<string>();
    private string[] _listingPrompts = {
        "Who are people that you appreciate?", 
        "What are personal strengths of yours?", 
        "Who are people that you have helped this week?", 
        "When have you felt the Holy Ghost this month?", 
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("LISTING ACTIVITY", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public override void Start()
    {
        base.DisplayStartingMessage();
        ListItems(); 
        base.DisplayEndingMessage();
        base.ReturnToMenu();
    }

    private void ListItems()
    {
        Console.WriteLine("\nList as many responses as you can to the following prompt:");

        string randomPrompt = _listingPrompts[new Random().Next(_listingPrompts.Length)];
        Console.WriteLine($"\n--- {randomPrompt} ---");

        Countdown();

        DateTime endTime = DateTime.Now.AddSeconds(_userDuration);

        int items = 0;

        do
        {
            Console.Write($"> ");
            string userInput = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(userInput))
            {
                _userResponses.Add(userInput);
                items++;
            }
            else
            {
                break;
            }
        } while (DateTime.Now < endTime);

        Console.WriteLine($"\nYou listed {items} items");

        // for (int i = 0; i < _userResponses.Count; i++)
        // {
        //     Console.WriteLine($"Item {i + 1}: {_userResponses[i]}");
        // }

    }
}