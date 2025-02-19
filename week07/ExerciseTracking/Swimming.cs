
public class Swimming : Activity
{
    private double _laps;
    public Swimming(string date, double lenght, double laps) : base(date,lenght)
    {
        _laps = laps;

    }
    public override double Distance()
    {
        return _laps * 50.0 / 1000;
    }
    public override double Speed()
    {
        return Distance() / _lenght *60;
    }
    public override double Pace()
    {
        return _lenght/Distance();
    }
    public override string GetSummary()
    {
        return$"{_date} Swimming ({_lenght} min) - Distance: {Distance()} km, Speed: {Speed()} kph, Pace: {Pace()} min per km.";
    }
}