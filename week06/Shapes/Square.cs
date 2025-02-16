using System;
using System.Drawing;

public class Square : Shape
{
    private double _side;

    public Square(double side, string color) : base(color)
    {
        _side = side;

    }

    public override double GetAre()
    {
        return _side * _side ;
    }

    // public void Display()
    // {
    //     Console.WriteLine($"{_color} el area es {_side}");
    // }
}