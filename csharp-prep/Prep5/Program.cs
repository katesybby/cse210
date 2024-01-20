// FUNCTIONS (NAME + SQUARED #)

using System;

class Program
{
    static void Main(string[] args)
    {
        //MAIN FUNCTION:
        DisplayWelcome();   //calls function
        string userName = PromptUserName();     //calls variable in a function
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);   //passes dif function variable into this function
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("\nWELCOME TO THE PROGRAM!!!");  
    }

    static string PromptUserName() 
    {
        Console.Write("\nwhat's your name? ");
        string userName = Console.ReadLine();  

        return userName;  
    }

    static int PromptUserNumber()
    {
        Console.Write("what's your favorite number? ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber; 
    }


    static int SquareNumber(int userNumber)
    {
        //takes userNumber and squares it
        int squaredNumber = userNumber * userNumber;

        return squaredNumber;
    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"Hello {userName}! The square of your fave number is: {squaredNumber}");
    }
}



/* 
For this assignment, write a C# program that has several simple functions:
- DisplayWelcome - Displays the message, "Welcome to the Program!"
- PromptUserName - Asks for and returns the user's name (as a string)
- PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
- SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer) 
- DisplayResult - Accepts the user's name and the squared number and displays them. 
Your Main function should then call each of these functions saving the return values and passing data to them as necessary.
*/
        //C# FUNCTION BONES:
        // returnType FunctionName(dataType parameter1, dataType parameter2)
        // {
        //    // function_body
        // }