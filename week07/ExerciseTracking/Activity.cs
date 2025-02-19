
public abstract class Activity
{
    protected string _date;
    protected double _lenght;
    
    public Activity (string date, double lenght)
    {
        _date = date;
        _lenght = lenght;

    }
    public abstract string  GetSummary();
    public virtual double Distance()
    {
        return -1;
    }
    public virtual double Speed()
    {
        return -1;
    }
    public virtual double Pace()
    {
        return -1;
    }
}