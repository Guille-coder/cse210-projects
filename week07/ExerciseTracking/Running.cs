
public class Running : Activity
{
    private double _distance;
    public Running(string date, double lenght, double distance) : base(date,lenght)
    {
        _distance = distance;

    }
    public override double Pace()
    {
        return _lenght / _distance;
    }
    public override double Speed()
    {
        return 60/Pace() ;
    }
    
    public override string GetSummary()
    {
        return$"{_date} Running ({_lenght} min) - Distance: {_distance} km, Speed: {Speed()} kph, Pace: {Pace()} min per km. ";
    }
    
}