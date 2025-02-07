using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Guillermo Aguirre","Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        MathAssignmen mathAssignmen1 = new MathAssignmen("Roberto","Fraction","7.3","8-19");
        Console.WriteLine(mathAssignmen1.GetSummary());
        Console.WriteLine(mathAssignmen1.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writing1 = new WritingAssignment("Mary Waters", "European History","The Causes of World War II by Mary Waters");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
    }
}