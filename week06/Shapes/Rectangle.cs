using System;

public class Rectangle : Shape
{
    private double _lenght;
    private double _widht;

    public Rectangle(double lenght, double widht, string color) : base(color)
    {
        _lenght = lenght;
        _widht = widht;
    }

    public override double GetAre()
    {
        return (_widht*_lenght);
    }
}