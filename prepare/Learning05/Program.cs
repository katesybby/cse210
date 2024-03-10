using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();   //list of shapes

        shapes.Add(new Square("SQUARE", "pink", 1.2));
        shapes.Add(new Rectangle("RECTANGLE", "pink-ish", 3.4, 5.6));
        shapes.Add(new Circle("CIRCLE", "totally-pink", 7.8));

        Console.Clear();

        foreach (var shape in shapes)   //for each shape, display color + area
        {
            Console.WriteLine($"{shape._shape}:");
            Console.WriteLine($"color = {shape._color}");
            Console.WriteLine($"area = {shape.GetArea()}\n");
        }
    }
}