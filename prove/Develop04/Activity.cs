using System;
using System.Threading;
using System.Collections.Generic;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _userDuration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.Write($"--------------------------- {_name} ---------------------------");
        Console.WriteLine($"\n\n{_description}");
        Console.Write("\nSet duration (seconds): ");
        while(!int.TryParse(Console.ReadLine(), out _userDuration))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");   //protects against user error
        }
        Console.WriteLine($"\nPrepare to begin...\n");
        Pause();
    }
    
    protected void DisplayEndingMessage()  
    {
        Console.WriteLine("\n\nGood job!");
        ShowSpinner();

        Console.WriteLine($"\nYou've completed {_name}.");
        Console.WriteLine($"Total time: {_userDuration} seconds."); 
        ShowSpinner();
    }

    protected void ShowSpinner(int duration = 4000)  
    {
        List<string> spinner = new List<string>()   //runs this: "|/-\|/-\|"
        {
            "|", "/", "-", "\\",
            "|", "/", "-", "\\"
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddMilliseconds(duration);

        while (DateTime.Now < endTime)
        {
            foreach (string s in spinner)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }

        //Thread.Sleep(duration - spinner.Count * 250);
    }

    protected void Pause(int duration = 5000)
    {
        Console.Clear();
        Console.WriteLine("Get ready...");  
        ShowSpinner();
    }

    public virtual void Start()
    {
        DisplayStartingMessage();
        //add more here?
        //Countdown(_userDuration);
        DisplayEndingMessage();
    }

    protected void ReturnToMenu()
    {
        Console.WriteLine("\n\nPress enter to return to the menu");
        Console.ReadLine();
        Console.Clear();
    }

    protected void Countdown()
    {
        Console.Write($"\nYou may begin in:  ");

        for (int i = 5; i > 0; i--)   //5 second countdown
        {
            Console.Write($"\b{i} \b");
            Thread.Sleep(1000);
        }

        Console.Write("\b \b");
        Console.WriteLine();
    }
}