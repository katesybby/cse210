// FIRST PROGRAM (BOND, JAMES BOND)

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        Console.WriteLine($"Your name is {last}, {first} {last}. ");
    }
}


//DESIRED OUTPUT
// What is your first name? Brigham
// What is your last name? Young

// Your name is Young, Brigham Young.