using System;

public class Cycling : Activity
{
    private double _distance;
    private bool _isMountainBike;

    public Cycling(string date, int minutes, double distance, bool isMountainBike) : base(date, minutes)
    {
        _name = "CYCLING";
        _distance = distance;
        _isMountainBike = isMountainBike;
    }

    public override double GetDistance() => _distance;
    public override double GetSpeedKph() => _distance / _minutes * 60;
    public override double GetSpeedMph() => GetSpeedKph() * 0.621371;
    public override double GetPaceMinPerKm() => _minutes / (GetDistance() / 1000);
    public override double GetPaceMinPerMile() => GetPaceMinPerKm() / 1.60934;
    public string GetBikeType() => _isMountainBike ? "Mountain Bike" : "Road Bike";   //false = road, true = mountain
}