using System;

public class MathAssignmen : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignmen(string studenName,string topic,string textbookSection, string problems) : base(studenName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;

    }
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }

}