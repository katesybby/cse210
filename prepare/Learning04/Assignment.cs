using System;

public class Assignment
{
    protected string _studentName = "";   //attributes
    private string _topic = "";

    public Assignment(string studentName, string topic)   //constructor
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()   //method
    {
        return $"{_studentName} - {_topic}";
    } 
}