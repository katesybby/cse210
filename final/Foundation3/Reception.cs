using System;

public class Reception : Event
{
    private string _email { get; }

    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public string ReturnEventType()
    {
        return "Reception";
    }

    public string GetReceptionDetails()
    {
        return $"{GetStandardDetails()}\nRSVP: {_email}\n";
    }

    public string GetReceptionShort()
    {
        return $"Event Type: {ReturnEventType()}\n{GetShortDetails()}\n";
    }
}
