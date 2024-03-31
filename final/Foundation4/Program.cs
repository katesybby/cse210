using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();

        // RUNNING ----------------------------------------------------------------
        Running running = new Running("10 Jan 2023", 45, 5.5);
        activityList.Add(running);

        // STATIONARY BIKE --------------------------------------------------------
        StationaryBike stationaryBike = new StationaryBike("15 Feb 2023", 60, 25.0);
        activityList.Add(stationaryBike);

        // SWIMMING ---------------------------------------------------------------
        Swimming swimming = new Swimming("20 Mar 2023", 40, 15);
        activityList.Add(swimming);

        Console.WriteLine("Activities:\n");
        foreach (Activity activity in activityList)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
