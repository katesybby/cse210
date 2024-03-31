using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _name = "Swimming";
        _laps = laps;
    }

    public override double GetDistance() => _laps * 50 / 1000;

    public override double GetSpeed() => (GetDistance() / _minutes) * 60;

    public override double GetPace() => _minutes / GetDistance();
}