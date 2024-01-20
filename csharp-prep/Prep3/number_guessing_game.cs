// GUESS THE NUMBER GAME

using System;

class Program
{
    static void Main(string[] args)
    {
        int attempts = 0
        while (restart = "y")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);

            int guess = -1;

            do 
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine("RESTART? (y/n) ")
                }
            }
            while (guess != number);
        }
        

    }
}