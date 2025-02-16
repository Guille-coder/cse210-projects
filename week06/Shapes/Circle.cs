using System;

public class Circles : Shape
{
    private double _radius;

    public Circles(double radius, string color ) : base(color)
    {
        _radius = radius;
    }

    public override double GetAre()
    {
        return 3.1416*(_radius * _radius);
    }
}