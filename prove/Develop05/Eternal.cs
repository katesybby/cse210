using System;

public class Eternal : Goal
{
    public string _description { get; set; }
    public string _goalType { get; } = "Eternal";
    
    public Eternal(string name, int points, string description) : base(name, points)
    {
        _description = description;
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

    public override void RecordEvent(ref int totalPoints)
    {
        // base.RecordEvent(ref totalPoints);
        _completed = false;
        _status = "[ ]";   //incomplete
        totalPoints += _points; 
    }
}
