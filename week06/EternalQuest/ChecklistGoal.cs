class ChecklistGoal : Goal
{
    private int _target;
    private int _timesCompleted = 0;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public ChecklistGoal(string name, string description, int points, bool completed, int target, int timesCompleted, int bonus) : base(name, description, points, completed)
    {
        _target = target;
        _timesCompleted = timesCompleted;
        _bonus = bonus;
    }
   
    public override void DisplayGoal()
    {
        string X ="";
        if (_completed)
        {
            X = "X";
        }
        Console.WriteLine($"[{X}] {_name}: {_description} ({_timesCompleted}/{_target})");
    }
   
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal| {_name}| {_description}| {_points}| {_completed}| {_target}| {_timesCompleted}| {_bonus}";
    }

    public override int Completion()
    {
        if (_completed)
        {
            Console.WriteLine("This goal has already been completed");
            return 0;
        }
        else
        {
            _timesCompleted = _timesCompleted + 1;
            if(_timesCompleted == _target)
            {
                Console.WriteLine($"You have completed this goal! You will be rewarded {_points} points + {_bonus} points for completion\n");
                _completed = true;
                return _points + _bonus;
            }
            else
            {
                Console.WriteLine($"Progress on goal: {_timesCompleted}/{_target}. You are rewarded {_points} points for your progress.");
                return _points;
            }
        }
    }
}

