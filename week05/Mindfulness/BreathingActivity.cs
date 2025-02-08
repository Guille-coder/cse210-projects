using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
    {
        _name = "Breathing";
        _description = "This actvity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            
            Console.Write($"\nBreath in...");ShowCountDown(4);
            Console.Write("Now breath out...");ShowCountDown(6);
            // Thread.Sleep(1000);
            
        }

        DisplayEndingMessage();
    }
    public string GetName()
    {
        return _name;
    }
    public int GetDuration()
    {
        return _duration;
    }
}