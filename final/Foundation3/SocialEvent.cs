using System;

public class SocialEvent : Event
{
    public SocialEvent(string title, string description, string date, string time, Address address, string details = "" ) : base(title, description, date, time, address)
    {
    }

    public string ReturnEventType()
    {
        return "Social Event";
    }

    public string GetSocialEventDetails()
    {
        return $"{GetStandardDetails()}";
    }

    public string GetSocialEventShort()
    {
        return $"\x1b[1mEvent Type:\x1b[0m {ReturnEventType()}\n{GetShortDetails()}\n"; 
    }
}