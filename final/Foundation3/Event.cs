using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GetStandardDetails()    //\x1b[1mTEXT\x1b[0m => how to bold text
    {
        return $"\x1b[1mTitle:\x1b[0m {_title}\n\x1b[1mDescription:\x1b[0m {_description}\n\x1b[1mDate/Time:\x1b[0m {_date} | {_time}\n\x1b[1mLocation:\x1b[0m {_address.GetFullAddress()}\n";
    }

    public virtual string GetShortDetails()
    {
        return $"\x1b[1mTitle:\x1b[0m {_title}\n\x1b[1mDate:\x1b[0m {_date}\n";   
    }
}
