using System;

public class StationaryBike : Activity
{
    private double _speed;

    public StationaryBike(string date, int minutes, double speed) : base(date, minutes)
    {
        _name = "Stationary Bike";
        _speed = speed;
    }

    public override double GetDistance() => (_speed * _minutes) / 60;

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed;
}
