using System;

public class OutdoorGathering : Event
{
    private string _weather { get; }

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string ReturnEventType()
    {
        return "Outdoor Gathering";
    }

    public override string GetStandardDetails()
    {
        return $"{GetStandardDetails()}\n\x1b[1mWeather Forecast:\x1b[0m {_weather}\n";
    }

    public override string GetShortDetails()
    {
        return $"\x1b[1mEvent Type:\x1b[0m {ReturnEventType()}\n{GetShortDetails()}\n";  
    }
}
