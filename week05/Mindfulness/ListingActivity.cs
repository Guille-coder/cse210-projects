using System;

public class ListingActivity : Activity
{
    private int _count;
    List<string> _prompt = new List<string>();

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This Activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("\nList as many responses you can to the following prompt:\n");
        GetRandomPrompt();
        Console.Write("You may begin in ");
        ShowCountDown(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            
            GetListFromUser();  
        }
        _count = _prompt.Count - _duration;
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();

    }
    public void GetRandomPrompt()
    {
        _prompt.AddRange(new[]{"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"});
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        Console.WriteLine($"––– {_prompt[index]} –––\n");
    }

    public List<string> GetListFromUser()
    {
        Console.Write("» ");
        _prompt.Add(Console.ReadLine());
        
        return _prompt;
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