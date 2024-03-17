using System;

public class Entry
{
    public int _totalPoints { get; set; }
    public string _goalType { get; set; }
    public string _name { get; set; }
    public int _points { get; set; }
    public string _description { get; set; }
    public string _status { get; set; }
    public int _bonus { get; set; }
    public int _frequency { get; set; }
    public bool IsCompleted { get; set; }
    public int _completedCount { get; set; }

    public Entry(string description)
    {
        _description = description;
        IsCompleted = false;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{_totalPoints}");
        if (_goalType == "Simple")
        {
           Console.WriteLine($"{_goalType}: {_name}, {_description}, {_points}, {_status}"); 
        }
        else if (_goalType == "Eternal")
        {
           Console.WriteLine($"{_goalType}: {_name}, {_description}, {_points}"); 
        }
        else //checklist
        {
           Console.WriteLine($"{_goalType}: {_name}, {_description}, {_points}, {_bonus}, {_frequency}, {_completedCount}");
        }
        
    }
}