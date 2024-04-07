using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //INTRO:
        Console.Clear();
        Console.Write("Enter username: ");
        string _username = Console.ReadLine();

        Console.Clear();
        Console.WriteLine($"\nWelcome @{_username}!\n");


        List<Video> videosList = new List<Video>();

        //VIDEOS -----------------------------------------------------
        Video video1 = new Video("10 Cute Cats Compilation", "CuteAnimalsChannel", 10);
        Video video2 = new Video("Dog Training Tips", "K9TrainingExperts", 22);
        Video video3 = new Video("Bird Watching in the Wild", "NatureExplorer", 36);


        //COMMENTS -----------------------------------------------------
        video1.AddComment(new Comment("@CatLover123", "These cats are adorable!"));
        video1.AddComment(new Comment("@CrazyCat", "Felines rock!"));
        video1.AddComment(new Comment("@I<3Cats", "ME-WOW! I wish I had more cats!"));

        video2.AddComment(new Comment("@DogWhisperer", "Great tips! Thanks for sharing"));
        video2.AddComment(new Comment("@PuppyLove22", "My dog learned so much from these videos"));
        video2.AddComment(new Comment("@CanineCompanion", "I'll try these with my new puppy!"));
        video2.AddComment(new Comment("@2DogLuvezr", "WOOF WOOF WOOF BARK WOOF"));

        video3.AddComment(new Comment("@BirdWatcher99", "These birds are stunning!!"));
        video3.AddComment(new Comment("@FeatherFanatic", "I love seeing them in their natural habitat."));
        video3.AddComment(new Comment("@AnimalAdmirer", "I like cats more."));


        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);


        //DISPLAY VIDEO INFO -----------------------------------------
        void DisplayVideos(List<Video> videosList)
        {
            foreach (Video video in videosList)
            {
                video.DisplayInfo();
                Console.WriteLine("\n");
            }   
        }

        while (true)
        {
            Console.WriteLine("---------------------------------- YOUTUBE ----------------------------------\n");

            DisplayVideos(videosList);

            Console.WriteLine("-----------------------------------------------------------------------------\n");

            Console.Write("Choose a video to comment on (1-3): ");

            int videoChoice;
            if (int.TryParse(Console.ReadLine(), out videoChoice) && videoChoice >= 1 && videoChoice <= videosList.Count)
            {
                Video chosenVideo = videosList[videoChoice - 1];

                Console.Write("Write your comment for this video: ");
                string userComment = Console.ReadLine();

                chosenVideo.AddComment(new Comment("@" + _username, userComment));

                Console.WriteLine("Comment added successfully!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
            }

            //loop continues till user exits
            Console.Write("\nWould you like to comment on another video? (y/n) ");
            string userChoice = Console.ReadLine().ToLower();

            if (userChoice == "y")
            {
                Console.Clear();
                continue;
            }
            else if (userChoice == "n")
            {
                Console.Clear();
                DisplayVideos(videosList);
                Console.WriteLine($"\nThank you for using YouTube @{_username}!");
                Console.WriteLine("Goodbye!");
                break;
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Invalid choice. Please enter 'y' or 'n'.");
            }
        }
    }
}

//---------------------------------------------------------------------------------------------------
//Exceeding Requirements:
//1. Prompting for username from user + welcome message
//2. Option for user to add multiple comments to video of their choosing. This includes the ability to see their comments.
//3. Gorgeous output formatting!