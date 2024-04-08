using System;

public class Lecture : Event
{
    private string _speaker { get; }
    private int _capacity { get; }

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string ReturnEventType()
    {
        return "Lecture";
    }

    public override string GetStandardDetails()
    {
        return $"{GetStandardDetails()}\n\x1b[1mSpeaker:\x1b[0m {_speaker}\n\x1b[1mCapacity:\x1b[0m {_capacity} max\n";
    }

    public override string GetShortDetails()
    {
        return $"\x1b[1mEvent Type:\x1b[0m {ReturnEventType()}\n{GetShortDetails()}\n";  
    }
}
