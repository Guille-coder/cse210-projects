using System;

public class Video
{
    string _title;
    string _author;
    int _hour;
    int _minute;
    int _seconds;
    List<Comment> _coments = new List<Comment>();


    public Video (string title, string author, int hour, int minute, int seconds)
    {
        _title = title;
        _author = author;
        _hour = hour;
        _minute = minute;
        _seconds = seconds;
    }
    public int GetSeconds()
    {
        return(_hour*3600)+(_minute*60)+_seconds;

    }
    public void comentList(Comment comment)
    {
        _coments.Add(comment);
    }
    public int Count()
    {
        return _coments.Count;
    }
    public void GetDisplayText()
    {
        Console.WriteLine($"Title: {_title} by {_author}");
        Console.WriteLine($"Length: {_hour}:{_minute}:{_seconds}");
        Console.WriteLine($"Seconds: {GetSeconds()}");
        Console.WriteLine($"Comment Count: {Count()}");
        foreach (Comment comment in _coments)
        {
            Console.WriteLine($"{comment.names()}: {comment.text()}");
        }
        Console.WriteLine("\n");
    }


    
}