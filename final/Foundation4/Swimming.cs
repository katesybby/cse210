using System;

public class Swimming : Activity
{
    private int _laps;
    private double _poolLapLength = 50;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _name = "SWIMMING";
        _laps = laps;
    }

    public double GetDistanceM() => _laps * _poolLapLength / 1000;
    public double GetDistanceI() => GetDistanceM() *  0.621371;
    public override double GetSpeedKph() => GetDistanceM() / _minutes * 60; 
    public override double GetSpeedMph() => GetSpeedKph() * 0.621371;
    public override double GetPaceMinPerKm() => _minutes / GetDistanceI(); 
    public override double GetPaceMinPerMile() => GetPaceMinPerKm() / 1.60934; 

    public override string GetSummary() => $"\x1b[1mDate/Time:\x1b[0m {_date} ~ {_minutes} min \n\x1b[1mDistance:\x1b[0m {GetDistanceM():F2} miles | {GetDistanceI():F2} km\n\n";
}