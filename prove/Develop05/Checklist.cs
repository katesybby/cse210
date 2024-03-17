using System;

public class Checklist : Goal
{
    public string _description { get; set; }
    public int _bonus { get; set; }
    public int _frequency { get; set; }
    public int _completedCount { get; set; }
    public string _goalType { get; } = "Checklist";
    
    public Checklist(string name, int points, string description, int bonus, int frequency) : base(name, points)
    {
        _description = description;
        _bonus = bonus;
        _frequency = frequency;
        _completedCount = 0;
    }

    public override void CreateGoal(string newDescription)
    {
        _description = newDescription;
    }

    public override void ListGoal()
    {
        base.ListGoal();

        int _completedCount = _goals.Count(entry => entry.IsCompleted);  
        Console.Write($" - {_description} | bonus: {_bonus} | Currently completed: {_completedCount}/{_frequency}"); 
    }

    public override void RecordEvent(ref int _totalPoints)
    {
        //base.RecordEvent(ref totalPoints);
        if (_completedCount == _frequency)
        {
            _completed = true;
            _status = "[X]";   
            _totalPoints += _points; 
        } 
        else
        {
            _completed = false;
            _status = "[ ]";   
        }
    }
    public int CalculateBonus()   //where does this need to be called?
    {
        return _bonus;
    }
}
