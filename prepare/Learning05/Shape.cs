using System;

public abstract class Shape   //abstract class <== abstract method
{
    // private string _color;   //member variable

    public string _shape { get; set; }   //getter + setter
    public string _color { get; set; }   

    public Shape(string shape, string color)   //constructor
    {
        _shape = shape;
        _color = color;
    }

    public abstract double GetArea();   //abstract method

    // public virtual double GetArea()   //virtual method
    // {
    //     return 0.0;
    // }

}