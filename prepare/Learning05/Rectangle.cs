using System;

public class Rectangle : Shape
{
    private double _sideA;
    private double _sideB;

    public Rectangle(string shape, string color, double sideA, double sideB) : base(shape, color)
    {
        _sideA = sideA;
        _sideB = sideB;
    }

    public override double GetArea()   //a = l * w
    {
        return _sideA * _sideB;
    }
}