using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear(); 
        Console.WriteLine("---------------------- WELCOME TO RELAXATION ----------------------");
        
        int userChoice;

        do
        {
            userChoice = GetUserChoice();

            Activity selectedActivity;

            switch (userChoice)
            {
                case 1:
                    selectedActivity = new BreathingActivity(); 
                    break; 
                case 2:
                    selectedActivity = new ReflectionActivity(); 
                    break; 
                case 3:
                    selectedActivity = new ListingActivity(); 
                    break; 
                case 0:
                    Console.WriteLine("\n\nGoodbye!");
                    Console.WriteLine("\nProgram ended."); 
                    return; 
                default:
                    Console.WriteLine("\nInvalid choice. Please try again.\n"); 
                    continue;
            }

            selectedActivity.Start();

        } while (true);   
    }

    //MENU
    static int GetUserChoice()
    {
        int userChoice;
        do
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("0. Quit");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");

            Console.Write("\nEnter the number of your choice (0-3): ");
        } while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 0 || userChoice > 3); 

        return userChoice;
    }
}