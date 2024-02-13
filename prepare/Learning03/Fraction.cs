using System;

public class Fraction
{
    private int _top;   //member variable = private
    private int _bottom;

//-----------------------------------------
    public Fraction()   //Constructor that has no parameters that initializes the number to 1/1.
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction (int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

//------------------------------------------
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

//-------------------------------------------
    public string GetFractionString()
    {
        return _top + "/" + _bottom;
        // string text = $"{_top}/{_bottom}";   //profs solution
        // return text;
    }

    public double GetDecimalValue()   //double: returning a decimal (up to 15 digits)
    {
        // return _top / _bottom;   //my solution
        return (double)_top / (double)_bottom;   //profs solution
    }
}