// LISTS (NUMBER LIST: SUM, AVG, MAX)

using System;
using System.Collections.Generic;   //need this when using Lists
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. "); 

        List<int> numbers = new List<int>();
        int numberList = -1;

        while (numberList != 0)
        {
            Console.Write("Enter number: ");
            string listNumbers = Console.ReadLine();
            numberList = int.Parse(listNumbers);

            if (numberList != 0)
            {
                numbers.Add(numberList);
            }
        }
        

        // int sum = numbers.Sum();
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // int count = Console.WriteLine(numbers.Count);    //counts number of inputs
        // int avg = ();   //uses sum and count
        double avg = Queryable.Average(numbers.AsQueryable());
        Console.WriteLine($"The average is: {avg}");
        
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}"); 

    }
}


/*
REQUIREMENTS:
1. Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
2. Compute the sum, or total, of the numbers in the list.
3. Compute the average of the numbers in the list.
4. Find the maximum, or largest, number in the list.
*/