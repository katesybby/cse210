using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // RANDOM WEATHER CREATOR ------------------------------------
        Random random = new Random();
        string[] weatherTypes = { "Sunny", "Cloudy", "Rainy", "Snow" }; 
        string randomWeather = weatherTypes[random.Next(weatherTypes.Length)];


        // LECTURE --------------------------------------------------
        Address address1 = new Address("123 University Avenue", "New York", "NY", "USA");
        Lecture lecture = new Lecture("Digital Marketing Trends", "Exploring the latest trends in digital marketing", "2024-04-05", "10:00 AM", address1, "John Smith", 100);

        Console.WriteLine("-------------- EVENT NUMBER 1: --------------\n");
        Console.WriteLine(lecture.GetLectureShort());
        Console.WriteLine(lecture.GetLectureDetails());


        // RECEPTION --------------------------------------------------
        Address address2 = new Address("456 Broadway Street", "Los Angeles", "CA", "USA");
        Reception reception = new Reception("Networking Mixer", "An evening of networking and socializing", "2024-05-20", "6:00 PM", address2, "rsvp@example.com");

        Console.WriteLine("-------------- EVENT NUMBER 2: --------------\n");
        Console.WriteLine(reception.GetReceptionShort());
        Console.WriteLine(reception.GetReceptionDetails());
        

        // OUTDOOR GATHERING --------------------------------------------------
        Address address3 = new Address("789 Ocean Avenue", "Sydney", "NSW", "Australia");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Beach Cleanup", "Join us for a day of cleaning up the beach", "2024-06-30", "9:00 AM", address3, randomWeather);

        Console.WriteLine("-------------- EVENT NUMBER 3: --------------\n");
        Console.WriteLine(outdoorGathering.GetOutdoorGatheringShort());
        Console.WriteLine(outdoorGathering.GetOutdoorGatheringDetails());


        //CONFERENCE --------------------------------------------------
        Address address4 = new Address("45 Elm Street", "Seattle", "WA", "USA");
        Conference conference = new Conference("Tech Summit 2024", "A gathering of industry leaders to discuss the latest tech trends", "2024-09-10", "9:00 AM", address4, "Elon Musk");

        Console.WriteLine("-------------- EVENT NUMBER 4: --------------\n");
        Console.WriteLine(conference.GetConferenceShort());
        Console.WriteLine(conference.GetConferenceDetails());


        //SOCIAL EVENT --------------------------------------------------
        Address address5 = new Address("101 Main Street", "Chicago", "IL", "USA");
        SocialEvent socialEvent = new SocialEvent("Company Holiday Party", "Celebrate the holidays with your colleagues!", "2023-12-20", "7:00 PM", address5);

        Console.WriteLine("-------------- EVENT NUMBER 5: --------------\n");
        Console.WriteLine(socialEvent.GetSocialEventShort());
        Console.WriteLine(socialEvent.GetSocialEventDetails());


        //WORKSHOP --------------------------------------------------
        Address address6 = new Address("78 Happy Lane", "Miami", "FL", "USA");
        Workshop workshop = new Workshop("Web Development Basics", "Learn the fundamentals of web development", "2024-07-15", "1:00 PM", address6, 20, "John Smith");

        Console.WriteLine("-------------- EVENT NUMBER 6: --------------\n");
        Console.WriteLine(workshop.GetWorkshopShort());
        Console.WriteLine(workshop.GetWorkshopDetails());
    }
}

//---------------------------------------------------------------------------------------------
//Exceeding Requirements:
//1. Improved output formatting
//2. Randomized weather conditions for Outdoor Gathering Events
//3. Added events Conference, Social Event, and Workshop each with their own unique details
