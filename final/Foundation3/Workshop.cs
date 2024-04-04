using System;

public class Workshop : Event
{
    private int _maxParticipants { get; }
    private string _instructor { get; }

    public Workshop(string title, string description, string date, string time, Address address, int maxParticipants, string instructor) : base(title, description, date, time, address)
    {
        _maxParticipants = maxParticipants;
        _instructor = instructor;
    }

    public string ReturnEventType()
    {
        return "Workshop";
    }

    public string GetWorkshopDetails()
    {
        return $"{GetStandardDetails()}\n\x1b[1mInstructor:\x1b[0m {_instructor}\n\x1b[1mMax Participants:\x1b[0m {_maxParticipants}\n";
    }

    public string GetWorkshopShort()
    {
        return $"\x1b[1mEvent Type:\x1b[0m {ReturnEventType()}\n{GetShortDetails()}\n"; 
    }
}