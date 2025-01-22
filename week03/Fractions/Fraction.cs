using System;
using System.Dynamic;
public class Fraction
{
    //two attributes for the top and bottom numbers
    private int _top;
    private int _bottom;

    //constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;

    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;

    }
    
    //Getters and Setters
    // public int GetTop()
    // {
    //     return _top;

    // }
    // public void SetTop(int top)
    // {
    //     _top = top;
    
    // }
    //  public int GetBottom()
    //  {
    //     return _bottom;
    //  }
    //  public void SetBottom(int bottom)
    //  {
    //     _bottom = bottom;
    //  }

     //methods
    public string GetFractionString()
    {
        string GetFraction = _top+ "/"+_bottom;
        return GetFraction;
    }
    public double GetDecimalValue()
    {
        return (double)_top/ (double)_bottom;

    }

}