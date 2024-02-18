using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Assignment assignment1 = new Assignment("Katesy Shepard", "C#");
        Console.WriteLine($"\n{assignment1.GetSummary()}\n");

        MathAssignment assignment2 = new MathAssignment("Katesy Shepard", "Calculus", "10.2", "15-63");
        Console.WriteLine($"\n{assignment2.GetSummary()}\n{assignment2.GetHomeworkList()}\n");

        WritingAssignment assignment3 = new WritingAssignment("Katesy Shepard", "Advanced Writing and Research", "Argument Essay");
        Console.WriteLine($"\n{assignment3.GetSummary()}\n{assignment3.GetWritingInformation()}\n");
    }
}