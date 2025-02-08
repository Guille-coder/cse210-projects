using System;

public class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspect of your life.";

    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("\nConsider the following Propmt:\n");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: "); ShowCountDown(5);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();ShowSpinner(10);
            Console.WriteLine();
        }


        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        _prompts.AddRange(new[]{"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."});
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        string getQuiestion;
        _questions.AddRange(new[]{"Why was this experience meaningful to you?","Have you ever done anything like this before?",
        "How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"});
        
        Random random = new Random();
        int index = random.Next(_questions.Count);
        getQuiestion = _questions[index];

        return getQuiestion;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"––– {GetRandomPrompt()} –––\n");

    }
    public void DisplayQuestions()
    {
        Console.Write($"» {GetRandomQuestion()}");
        
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