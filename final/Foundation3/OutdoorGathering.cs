using System;

public class OutdoorGathering : Event
{
    private string _weather { get; }

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return $"The weather will be: {_weather}.\n";
    }

    public string ReturnEventType()
    {
        return "Outdoor Gathering";
    }

    public string GetOutdoorGatheringDetails()
    {
        return $"{GetStandardDetails()}\nStatement of the Weather: {GetWeather()}\n";
    }

    public string GetOutdoorGatheringShort()
    {
        return $"Event Type: {ReturnEventType()}\n{GetShortDetails()}\n";
    }
}
