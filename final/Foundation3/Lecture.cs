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

    public string GetLectureDetails()
    {
        return $"{GetStandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}max\n";
    }

    public string GetLectureShort()
    {
        return $"Event Type: {ReturnEventType()}\n{GetShortDetails()}\n";
    }
}
