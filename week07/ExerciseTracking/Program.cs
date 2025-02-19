using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        
        Running running = new Running("08 Feb 2025",30,20);
        Cycling cycling = new Cycling("09 Feb 2025",40,30);
        Swimming swimming = new Swimming("10 Feb 2025",30,30);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}