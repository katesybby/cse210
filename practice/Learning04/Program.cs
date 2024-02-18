using System;
using library_demo;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.SetAuthor("Dr. Seuss");
        book1.SetTitle("Oh, the Places You'll Go!");

        Console.WriteLine($"book1.GetBookInfo()");

        PictureBook book2 = new PictureBook();
        book2.SetAuthor("Jones");
        book2.SetTitle("Wonderful Picture Book");
        book2.SetIllustrator("Jane Doe");

        Console.WriteLine($"book2.GetBookInfo()");
        Console.WriteLine($"book2.GetPictureBookInfo()");

        Book book3 = new Book("Edwards", "The Catcher in the Rye");
        Console.WriteLine($"book3.GetBookInfo()");

        PictureBook book4 = new PictureBook();
        Console.WriteLine($"book4.GetBookInfo()");

    }
}