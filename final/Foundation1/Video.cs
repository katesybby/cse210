using System;

public class Video
{ 
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>(); 

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int CountComments()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"\n\x1b[1m{_title}\x1b[0m | \x1b[1m{_author}\x1b[0m | {_length} minutes\n");   //\x1b[1mTEXT\x1b[0m = bold (this took so much effort to figure out for absolutely no reason)
        Console.WriteLine($"-------------------- COMMENTS ({CountComments()}) -------------------\n");
        foreach (Comment comment in _comments)
        {
            comment.DisplayInfo();
        }
        Console.WriteLine("\n-----------------------------------------------------");
    } 
}