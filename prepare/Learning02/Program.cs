using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Life";
        job1._jobTitle = "Super Hot Person";
        job1._startYear = 2003;
        job1._endYear = 2024;
        //job1.Display();

        Job job2 = new Job();
        job2._company = "Savior of Gotham City";
        job2._jobTitle = "BATMAN";
        job2._startYear = 0000;
        job2._endYear = 9999;
        //job2.Display();

        Resume resume = new Resume();
        resume._name = "Katesy Shepard";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}


//CLASS NOTES
//object: emphasis (class name)
//responsibility: why
//state: adjective (variables)
//behaviors: verbs (functions)

//always singular


//how to create a new c# folder:
// katesyshepard@Katesys-MacBook-Air ~ % dotnet new console -o CSE210-Demo-Winter-2024
