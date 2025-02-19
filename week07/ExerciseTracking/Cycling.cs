public class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, double lenght, double speed) : base(date,lenght)
    {
        _speed = speed;

    }
    public override double Distance()
    {
        double hour = _lenght/60.0;

        return hour * _speed;
    }
    public override double Pace()
    {
        return 60.0 / _speed;
    }
    public override string GetSummary()
    {
        return$"{_date} Cycling ({_lenght} min) - Distance: {Distance()} km, Speed: {_speed} kph, Pace: {Pace()} min per km. ";;
    } 
        
    
}