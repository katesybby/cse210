using System;

class Program
{
    static void Main(string[] args)
    {
        // LECTURE --------------------------------------------------
        Address address1 = new Address("123 University Avenue", "New York", "NY", "USA");
        Lecture lecture = new Lecture("Digital Marketing Trends", "Exploring the latest trends in digital marketing", "2024-04-05", "10:00 AM", address1, "John Smith", 100);

        Console.WriteLine("Event Number 1: \n");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetLectureDetails());
        Console.WriteLine(lecture.GetLectureShort());


        // RECEPTION --------------------------------------------------
        Address address2 = new Address("456 Broadway Street", "Los Angeles", "CA", "USA");
        Reception reception = new Reception("Networking Mixer", "An evening of networking and socializing", "2024-05-20", "6:00 PM", address2, "rsvp@example.com");

        Console.WriteLine("Event Number 2: \n");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetReceptionDetails());
        Console.WriteLine(reception.GetReceptionShort());


        // OUTDOOR GATHERING --------------------------------------------------
        Address address3 = new Address("789 Ocean Avenue", "Sydney", "NSW", "Australia");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Beach Cleanup", "Join us for a day of cleaning up the beach", "2024-06-30", "9:00 AM", address3, "Sunny");

        Console.WriteLine("Event Number 3: \n");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetOutdoorGatheringDetails());
        Console.WriteLine(outdoorGathering.GetOutdoorGatheringShort());
    }
}
