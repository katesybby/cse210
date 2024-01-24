public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public Job()
    {
    }

    public void Display()
    {
        Console.WriteLine($"\nCompany: {_company}\n Job: {_jobTitle}\n Dates: {_startYear}-{_endYear}");
    }
}


/*
JOB
_company: string
_jobTitle: string
_startYear: int
_endYear: int
Display(): void
*/