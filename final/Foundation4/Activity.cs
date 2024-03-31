using System;

public class Activity
{
    protected string _date;
    protected int _minutes;
    protected string _name;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double GetDistance() => 0;   //shortcut for return 0;

    public virtual double GetSpeed() => 0;

    public virtual double GetPace() => 0;

    public string GetSummary() => $"{_date} {_name} ({_minutes}min)- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    
}
