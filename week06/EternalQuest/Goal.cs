using System.ComponentModel;
//This is the parent class to all other goal classes
class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _completed = false;
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public Goal(string name, string description, int points, bool completed)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = completed;
    }
   
    public string GetName()
    {
        return _name;
    }
    
    public virtual int Completion()
    {
        if(_completed)
        {
            Console.WriteLine("You have already completed this goal");
            return 0;
        }
        else
        {
            Console.WriteLine($"You have completed this goal! You will be rewarded {_points} points\n");
            _completed = true;
            return _points;
        }
    }
   
    public virtual void DisplayGoal()
    {
        string X ="";
        if (_completed)
        {
            X = "X";
        }
        Console.WriteLine($"[{X}] {_name}: {_description}");
    }
 
    public virtual string GetStringRepresentation()
    {
        return "";
    }

}