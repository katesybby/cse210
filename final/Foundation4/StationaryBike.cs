using System;

public class StationaryBike : Activity
{
    private double _speed;

    public StationaryBike(string date, int minutes, double speed) : base(date, minutes)
    {
        _name = "STATIONARY BIKE";
        _speed = speed;
    }

    public override double GetDistance() => _speed * _minutes / 60;
    public override double GetSpeedKph() => _speed;
    public override double GetSpeedMph() => GetSpeedKph() * 0.621371;
    public override double GetPaceMinPerKm() => 60 / _speed * 1000;
    public override double GetPaceMinPerMile() => GetPaceMinPerKm() / 1.60934;
}
