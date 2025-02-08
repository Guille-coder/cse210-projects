using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity \n");
        Console.WriteLine(_description);
        Console.Write($"\nHow long, in seconds, would you like for your sesion? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell Done");
        ShowSpinner(5);
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
        Console.Clear();

    }
    public void ShowSpinner(int seconds)
    {
        List<string> SpinnerList = new List<string>();
        SpinnerList.AddRange(new[]{"|","/","—","\\"});
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = SpinnerList[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i ++;
            if (i >= SpinnerList.Count)
            {
                i=0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i=seconds ; i > 0 ; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
        Console.WriteLine();

    }
}