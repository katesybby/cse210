using System;

public class Hiking : Activity
{
    private double _distance;
    private double _incline;

    public Hiking(string date, int minutes, double distance, double incline) : base(date, minutes)
    {
        _name = "HIKING";
        _distance = distance;
        _incline = incline;
    }

    public override double GetDistance() => _distance;
    public double GetSpeedKph() => _distance / _minutes * 60;
    public double GetSpeedMph() => GetSpeedKph() * 0.621371;   
    public double GetPaceMinPerKm() => _minutes / (GetDistance() / 1000); 
    public double GetPaceMinPerMile() => GetPaceMinPerKm() / 1.60934;
    public double GetInclineRate() => _incline / _minutes * 60;   //meters / min
}