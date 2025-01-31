using System;

public class Comment
{
    string _nameOfPerson;
    string _textOfComment;

    public Comment (string name, string text)
    {
        _nameOfPerson = name;
        _textOfComment = text;
    }
    
    public void display()
    {
        Console.WriteLine($"{_nameOfPerson}: {_textOfComment}");

    }


}