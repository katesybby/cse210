using System;

public class Circle : Shape
{
    private double _radius;

    public Circle(string shape, string color, double radius) : base(shape, color)
    {
        _radius = radius;
    }

    public override double GetArea()   //a = pi * r^2
    {
        return Math.PI * (_radius * _radius);
    }
}