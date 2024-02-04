using System;

public class File  //EXTRA: File class including methods SaveToFile() and LoadFromFile()
{
    public void SaveToFile() //saves to file
    {
        Console.Write("\nEnter filename (ex: journal.txt): ");
        string filenameSave = Console.ReadLine();

        Console.WriteLine($"Journal saved to {filenameSave}");
    }

    public void LoadFromFile()  //loads from file. something isn't working right though...
    {
        Console.Write("\nEnter filename (ex: journal.txt): ");
        string filenameLoad = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filenameLoad))
        {
            outputFile.WriteLine($"Content of {filenameLoad} file:\n");

            string[] lines = System.IO.File.ReadAllLines(filenameLoad);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}


//----------------------------------------------------------------------------
//previous attempt (load):
        // Console.Write("\nEnter filename (ex: journal.txt): ");
        // string filenameLoad = Console.ReadLine();

        // // LoadFromFile(fileName);

        // Console.WriteLine($"Journal loaded from {filenameLoad}");