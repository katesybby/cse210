using System;

public class Simple : Goal
{
    public string _description { get; set; }
    public int _completedCount { get; set; }
    public string _goalType { get; } = "Simple";   //read-only property
    
    public Simple(string name, int points, string description) : base( name, points)
    {
        _description = description;
        _completedCount = 0;
    }

    public override void RecordEvent(ref int _totalPoints)
    {
        base.RecordEvent(ref _totalPoints);
        _completedCount++;
        if (_completedCount >= _points)
        {
            _completed = true;
            _totalPoints += _points; 
            _status = "[X]";   //this means completed
        }
    }

    public override void CreateGoal(string description)
    {
        _description = description;
    }

    public override void ListGoal()
    {
        base.ListGoal();
        Console.Write($" - {_description}");
    }
}