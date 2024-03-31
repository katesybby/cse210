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

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate/Time: {_date} | {_time}\n{_address.GetFullAddress()}\n";
    }

    public string GetShortDetails()
    {
        return $"Title: {_title}\nDate: {_date}\n";
    }
}
