using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
// using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWELCOME TO YOUR NEW JOURNAL!");
        Journal journal = new Journal();
        File file = new File();
        string userChoice = "1";

        while (userChoice != "5")
        {
            Console.WriteLine("\n--------MENU--------");
            Console.WriteLine("1. Write \n2. Display \n3. Save \n4. Load \n5. Exit");
            Console.Write("Enter your choice: ");

            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1": //WRITE
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");

                    Console.Write("Enter the journal entry content: ");
                    string content = Console.ReadLine();

                    Entry entry = new Entry();
                    entry._prompt = prompt;
                    entry._content = content;
                    entry._entryDate = DateTime.Now;

                    journal.AddEntry(entry); //prof did this dif > journal._entries.Add(entry);
                    break;

                case "2": //DISPLAY
                    Console.WriteLine("\n------- JOURNAL -------\n");

                    foreach(Entry singleEntry in journal.GetEntries()) //chatGPT did this dif > foreach (var entry in journal.GetEntries())
                    {
                        Console.WriteLine($"Date: {singleEntry._entryDate}\nPrompt: {singleEntry._prompt}\nContent: {singleEntry._content}\n");
                    }

                    Console.WriteLine("-------------------------\n");
                    break;

                case "3": //SAVE
                    file.SaveToFile();
                    break;

                case "4": //LOAD
                    file.LoadFromFile();
                    break;

                case "5": //EXIT
                    Console.WriteLine("GOODBYE!\n");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}


//----------------------------------------------------------------------------
//EXCEEDING CORE REQUIREMENTS:
//created an extra class "File" to simplify main code
