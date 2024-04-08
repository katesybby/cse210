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

    public override string GetStandardDetails()
    {
        return $"{GetStandardDetails()}\n\x1b[1mRSVP\x1b[0m @ {_email}\n";
    }

    public override string GetShortDetails()
    {
        return $"\x1b[1mEvent Type:\x1b[0m {ReturnEventType()}\n{GetShortDetails()}\n";   
    }
}
