using System;

public class Conference : Event
{
    private string _keynoteSpeaker { get; }

    public Conference(string title, string description, string date, string time, Address address, string keynoteSpeaker) : base(title, description, date, time, address)
    {
        _keynoteSpeaker = keynoteSpeaker;
    }

    public string ReturnEventType()
    {
        return "Conference";
    }

    public override string GetStandardDetails()
    {
        return $"{GetStandardDetails()}\n\x1b[1mKeynote Speaker:\x1b[0m {_keynoteSpeaker}\n";
    }

    public override string GetShortDetails()
    {
        return $"\x1b[1mEvent Type:\x1b[0m {ReturnEventType()}\n{GetShortDetails()}\n"; 
    }
}