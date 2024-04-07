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

    public virtual double GetDistance() => 0;   //shortcut for 'return 0';

    public virtual double GetSpeed() => 0;

    public virtual double GetPace() => 0;

    public virtual string GetSummary() => $"\x1b[1mDate/Time:\x1b[0m {_date} ~ {_minutes} min \n\x1b[1mDistance:\x1b[0m {GetDistance()} miles\n";
}
