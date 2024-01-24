public class Resume
{
    public string _name = "";

    public List<Job> _jobs = new List<Job>();
    public void Display()
    {
        Console.WriteLine("\nRESUME");
        Console.WriteLine($"Name: {_name}");
        

        foreach(Job job in _jobs)
        {
            job.Display();
        }
    }
}


/*
RESUME
_name: string
_jobs: List<Job>
Display(): void
*/