using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();

        Console.Clear();
        Console.WriteLine("---------------------- ACTIVITIES ----------------------\n"); 

        // RUNNING ----------------------------------------------------------------
        Running running = new Running("1/10/24", 45, 5.5);

        double RSpeedMph = running.GetSpeedMph();
        double RSpeedKph = running.GetSpeedKph();
        double RPaceMinPerKm = running.GetPaceMinPerKm();
        double RPaceMinPerMile = running.GetPaceMinPerMile();

        Console.WriteLine("------ RUNNING -------------------------\n");
        Console.WriteLine($"{running.GetSummary()}");
        Console.WriteLine($"\x1b[1mSpeed:\x1b[0m {RSpeedMph:F2} mph | {RSpeedKph:F2} kph");
        Console.WriteLine($"\x1b[1mPace:\x1b[0m {RPaceMinPerKm:F2} min/km | {RPaceMinPerMile:F2} min/mile\n");
        activityList.Add(running);

        // STATIONARY BIKE --------------------------------------------------------
        StationaryBike stationaryBike = new StationaryBike("2/15/24", 60, 25.0);

        double BSpeedMph = stationaryBike.GetSpeedMph();
        double BSpeedKph = stationaryBike.GetSpeedKph();
        double BPaceMinPerKm = stationaryBike.GetPaceMinPerKm();
        double BPaceMinPerMile = stationaryBike.GetPaceMinPerMile();

        Console.WriteLine("------ STATIONARY BIKE -----------------\n");
        Console.WriteLine($"{stationaryBike.GetSummary()}");
        Console.WriteLine($"\x1b[1mSpeed:\x1b[0m {BSpeedMph:F2} mph | {BSpeedKph:F2} kph");
        Console.WriteLine($"\x1b[1mPace:\x1b[0m {BPaceMinPerKm:F2} min/km | {BPaceMinPerMile:F2} min/mile\n");
        activityList.Add(stationaryBike);

        // SWIMMING ---------------------------------------------------------------
        Swimming swimming = new Swimming("3/20/24", 40, 15);

        double SSpeedMph = swimming.GetSpeedMph();
        double SSpeedKph = swimming.GetSpeedKph();
        double SPaceMinPerKm = swimming.GetPaceMinPerKm();
        double SPaceMinPerMile = swimming.GetPaceMinPerMile();

        Console.WriteLine("------ SWIMMING ------------------------\n");
        Console.WriteLine($"{swimming.GetSummary()}");
        Console.WriteLine($"\x1b[1mSpeed:\x1b[0m {SSpeedMph:F2} mph | {SSpeedKph:F2} kph");
        Console.WriteLine($"\x1b[1mPace:\x1b[0m {SPaceMinPerKm:F2} min/km | {SPaceMinPerMile:F2} min/mile\n");
        activityList.Add(swimming);

        // CYCLING ------------------------------------------------------------------
        Cycling cycling = new Cycling("4/5/24", 90, 12, false);

        double CSpeedMph = cycling.GetSpeedMph();
        double CSpeedKph = cycling.GetSpeedKph();
        double CPaceMinPerKm = cycling.GetPaceMinPerKm();
        double CPaceMinPerMile = cycling.GetPaceMinPerMile();

        Console.WriteLine("------ CYCLING -------------------------\n");
        Console.WriteLine($"{cycling.GetSummary()}");
        Console.WriteLine($"\x1b[1mSpeed:\x1b[0m {CSpeedMph:F2} mph | {CSpeedKph:F2} kph");
        Console.WriteLine($"\x1b[1mPace:\x1b[0m {CPaceMinPerKm:F2} min/km | {CPaceMinPerMile:F2} min/mile");
        Console.WriteLine($"\x1b[1mBike Type:\x1b[0m {cycling.GetBikeType()}\n");
        activityList.Add(cycling);

        // HIKING -----------------------------------------------------------------
        Hiking hiking = new Hiking("4/20/24", 120, 5.0, 300);

        double HSpeedMph = hiking.GetSpeedMph();
        double HSpeedKph = hiking.GetSpeedKph();
        double HPaceMinPerKm = hiking.GetPaceMinPerKm();
        double HPaceMinPerMile = hiking.GetPaceMinPerMile();

        Console.WriteLine("------ HIKING -------------------------\n");
        Console.WriteLine($"{hiking.GetSummary()}");
        Console.WriteLine($"\x1b[1mSpeed:\x1b[0m {HSpeedMph:F2} mph | {HSpeedKph:F2} kph");
        Console.WriteLine($"\x1b[1mPace:\x1b[0m {HPaceMinPerKm:F2} min/km | {HPaceMinPerMile:F2} min/mile");
        Console.WriteLine($"\x1b[1mIncline Rate:\x1b[0m {hiking.GetInclineRate()} m/min\n");
        activityList.Add(hiking);

        Console.WriteLine("-------------------------------------------------------\n");
    }
}

//------------------------------------------------------------------------------
//Exceeding Requirements:
//1. Added classes Cycling and Hiking, both with unique methods
//2. Used both metric and imperial units in calculations of distance, pace, and speed for all activities
//3. Stellar output formatting :)
