using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userPercent = Console.ReadLine();    //always returns string
        int percent = int.Parse(userPercent);    //string -> int

        if (percent>=90 && percent<=100)
        {
            if (percent<=93)
            {
                Console.WriteLine("A-");
            }
            else
            {
                Console.WriteLine("A");
            }
        Console.WriteLine("YASSSSS QUEEN!!! YOU PASSED!");
        }
        
        else if (percent>=80 && percent<=89)
        {
            if (percent>=87)
            {
                Console.WriteLine("B+");
            }
            else if (percent<=83)
            {
                Console.WriteLine("B-");
            }
            else
            {
                Console.WriteLine("B");
            }
            Console.WriteLine("B FOR YOU PASSED BESTIE!");
        }
        
        else if (percent>=70 && percent<=79)
        {
            if (percent>=77)
            {
                Console.WriteLine("C+");
            }
            else if (percent<=73)
            {
                Console.WriteLine("C-");
            }
            else
            {
                Console.WriteLine("C");
            }
            Console.WriteLine("C'S GET DEGREE'S! YOU PASSED!");
        }
        
        else if (percent>=60 && percent<=69)
        {
            if (percent>=67)
            {
                Console.WriteLine("D+");
            }
            else if (percent<=63)
            {
                Console.WriteLine("D-");
            }
            else
            {
                Console.WriteLine("D");
            }
            Console.WriteLine("WELP, YOU DID NOT PASS. BETTER LUCK NEXT TIME.");
        }
        
        else if (percent<60)
        {
            Console.WriteLine("F");
            Console.WriteLine("BIG FAT F. YOU DID NOT PASS :,(");
        }
        
        else
        {
            Console.WriteLine("Invalid response. RESTART.");
        }
    }
}


//REQUIREMENTS:
// Ask the user for their grade percentage and write a series of if-elif-else statements.

// Need at least a 70 to pass the class. Determine letter grade and printing it out. Display a message to congratulate or different message to encourage.

// Change your code -instead of printing the letter grade in the body of each if, elif, or else block, instead create a new variable called letter and then in each block, set this variable to the appropriate value. 
// Finally, have a single print statement that prints the letter grade once.


// A >= 90
// B >= 80
// C >= 70
// D >= 60
// F < 60