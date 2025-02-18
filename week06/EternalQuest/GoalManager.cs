
using System.Data;
using System.Drawing;

class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints = 0;
    private string _filename = "";
    private string _level = "Level X";
    public GoalManager(List<Goal> goals, int totalPoints)
    {
        _goals = goals;
        _totalPoints = totalPoints;
    }
    
    public void DisplayLevel()
    {
        Console.WriteLine($"You are a level {_level} with {_totalPoints} points");
    }
    
    public void AddGoal(Goal goal)
    {
        Console.Clear();
        _goals.Add(goal);
        Console.WriteLine("The new goal has been added!\n");
    }
    
    public void RemoveGoal()
    {
        Console.Clear();

        Console.WriteLine("Your Goals are: ");
        int n = 1;
        foreach(Goal g in _goals)
            {
                string goalName = g.GetName();
                Console.WriteLine($"  {n}. {goalName}");
                n = n + 1;
            }

        Console.WriteLine("Enter the number of the goal you would like to reomve, or push enter to cancle: ");
        string str_UserChoice = Console.ReadLine();
        int userPickedGoal; 
        Console.Clear();

        if (int.TryParse(str_UserChoice, out userPickedGoal))
        {
            int goalRemoved = userPickedGoal - 1;
            _goals.RemoveAt(goalRemoved);
            Console.WriteLine("The goal was removed\n");
        }
        else
        {
            Console.WriteLine("Action Canlced\n");
        }
    }
    
    public void RecordEvent()
    {
        Console.Clear();

        Console.WriteLine("Your Goals are: ");
        int n = 1;
        foreach(Goal g in _goals)
            {
                string goalName = g.GetName();
                Console.WriteLine($"  {n}. {goalName}");
                n = n + 1;
            }
        
        Console.WriteLine("Enter the number of the goal you accomplished or made progress on, or push enter to cancle: ");
        string str_UserChoice = Console.ReadLine();
        int userPickedGoal;
        Console.Clear();

        if (int.TryParse(str_UserChoice, out userPickedGoal))
        {
            Goal goalAccomplished = _goals[userPickedGoal-1];
            int pointsEarned = goalAccomplished.Completion();
            _totalPoints = _totalPoints + pointsEarned;
        }
        else
        {
            Console.WriteLine("Action Canlced\n");
        }
        
        LevelUp();
    }
    
    public void DisplayGoals()
    {
        Console.Clear();
        foreach(Goal g in _goals)
        {
            g.DisplayGoal();
        }

        Console.WriteLine("Push Enter to return to the Menu");
        Console.ReadLine();
        Console.Clear();
    }
    

    public void Save()
    {   
        Console.Clear();
        
        bool ChangeFileName = true;
        if(_filename != "")
        {
            Console.WriteLine("If you would like to save to the same file as before, enter 1");
            Console.WriteLine("If you would like to save to a new file, press enter: ");
            string str_fileChoice = Console.ReadLine();
            int fileChoice;
            
            if(int.TryParse(str_fileChoice, out fileChoice))
            {
                if (fileChoice == 1)
                {
                    ChangeFileName = false;
                }
            }
        }
        if(ChangeFileName)
        {
            Console.WriteLine("What would you like the title of this save file to be? ");
            _filename = Console.ReadLine();
        }
        using (StreamWriter outputfile = new StreamWriter(_filename))
        {
            outputfile.WriteLine(_totalPoints + "| " + _level); 

            foreach(Goal g in _goals)
            {
                outputfile.WriteLine(g.GetStringRepresentation()); 
            }
        }
        Console.Clear();
        Console.WriteLine("Your progross has been saved!\n");
    }
    public void Load()
    {
        Console.Clear();
        List<Goal> loadedGoals = new List<Goal>();

        Console.WriteLine("What is the name of the save file to be loaded? ");
        _filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines)
        {   
            string[] parts = line.Split("| ");

            if (parts.Count() == 2) 
            {
                _totalPoints = int.Parse(parts[0]);
                _level = parts[1];
            }
            else
            {
                Goal loadedGoal = new Goal("name", "description", 0);

                if(parts[0] == "SimpleGoal")
                {
                    loadedGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                }
                else if(parts[0] == "EternalGoal")
                {
                    loadedGoal = new EternalGoal(parts[1],parts[2], int.Parse(parts[3]));
                }
                else if(parts[0] == "ChecklistGoal")
                {
                    loadedGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                }

                loadedGoals.Add(loadedGoal);
            }
        }
        _goals = loadedGoals;
        Console.Clear();
        Console.WriteLine("Your Goals have been loaded.\n");        
    }
    public void LevelUp()
    {
        string startLevel = _level; 
        if(_totalPoints > 0)
        {
            _level = "The Hero´s Path";
        }
        if(_totalPoints > 500)
        {
            _level = "Challenge After Challenge";
        }
        if(_totalPoints > 1500)
        {
            _level = "The Final Test";
        }
        if(_totalPoints > 3000)
        {
            _level = "Worlds to Discover";
        }
        if(_totalPoints > 5000)
        {
            _level = "Ascent To Glory";
        }
        if(_totalPoints > 7000)
        {
            _level = "The Legend Continues";
        }
        if(_totalPoints > 10000)
        {
            _level = "Beyond the Goal";
        }
        if(_totalPoints > 15000)
        {
            _level = "The Neverending Journey";
        }
        if(_totalPoints > 20000)
        {
            _level = "Where It All Begins";
        }

        if(startLevel != _level)
        {
            Console.WriteLine("You leveled up!");
        }
    }
}