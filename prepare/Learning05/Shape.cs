using System;

public abstract class Shape   //abstract class <== abstract method
{
    // private string _color;   //member variable

    public string Color { get; set; }   //getter + setter

    public Shape(string color)   //constructor
    {
        Color = color;
    }

    public abstract double GetArea();   //abstract method

    // public virtual double GetArea()   //virtual method
    // {
    //     return 0.0;
    // }

}