
class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points){}

    public override int Completion()
    {
        Console.WriteLine($"You will be rewarded {_points} points\n");
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal| {_name}| {_description}| {_points}";
    }
}