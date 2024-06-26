using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Goal
{
    public string _name { get; set; }
    public int _points { get; set; }
    public string _status { get; set; }
    public bool _completed { get; set; }
    public List<Entry> _goals = new List<Entry>();  

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _status = "[ ]";   //this means incomplete (default) 
        _completed = false;
    }

    public virtual void CreateGoal(string description)
    {
        Console.WriteLine("Creating a base goal...");
    }
    public virtual void ListGoal()
    {
        Console.Write($"{_status} {_name} ({_points} pts)"); 
    }
    
    public virtual void RecordEvent(ref int _totalPoints)    //something wrong here
    {
        _completed = false;   //default settings
        _status = "[ ]";  
        _totalPoints += _points;   

        string eventDescription = Console.ReadLine();

        Entry entry = new Entry(eventDescription);
        _goals.Add(entry);
    }

    public virtual bool IsCompleted()
    {
        return _completed;
    } 
}
