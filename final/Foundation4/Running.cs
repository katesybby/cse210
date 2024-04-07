using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _name = "RUNNING";
        _distance = distance;
    }

    public override double GetDistance() => _distance;
    public double GetSpeedKph() => _distance / _minutes * 60;   
    public double GetSpeedMph() => GetSpeedKph() * 0.621371;   
    public double GetPaceMinPerKm() => _minutes / (GetDistance() / 1000);   
    public double GetPaceMinPerMile() => GetPaceMinPerKm() / 1.60934;   
}
