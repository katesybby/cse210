using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        //VIDEO 1 -----------------------------------------------------
        Video video1 = new Video("10 Cute Cats Compilation", "CuteAnimalsChannel", 180);

        Comment comment1_1 = new Comment("CatLover123", "These cats are adorable!");
        Comment comment1_2 = new Comment("CrazyCat", "Felines rock!");
        Comment comment1_3 = new Comment("I<3Cats", "ME-WOW! I wish I had more cats!");

        video1.ListComment(comment1_1);
        video1.ListComment(comment1_2);
        video1.ListComment(comment1_3);

        videosList.Add(video1);


        //VIDEO 2 -----------------------------------------------------
        Video video2 = new Video("Dog Training Tips", "K9TrainingExperts", 240);
        
        Comment comment2_1 = new Comment("DogWhisperer", "Great tips! Thanks for sharing");
        Comment comment2_2 = new Comment("PuppyLove22", "My dog learned so much from these videos");
        Comment comment2_3 = new Comment("CanineCompanion", "I'll try these with my new puppy'");

        video2.ListComment(comment2_1);
        video2.ListComment(comment2_2);
        video2.ListComment(comment2_3);

        videosList.Add(video2);


        //VIDEO 3 -----------------------------------------------------
        Video video3 = new Video("Bird Watching in the Wild", "NatureExplorer", 300);

        Comment comment3_1 = new Comment("BirdWatcher99", "These birds are stunning!!");
        Comment comment3_2 = new Comment("FeatherFanatic", "I love seeing them in their natural habitat.");
        Comment comment3_3 = new Comment("AnimalAdmirer", "I like cats more.");

        video3.ListComment(comment3_1);
        video3.ListComment(comment3_2);
        video3.ListComment(comment3_3);

        videosList.Add(video3);


        //DISPLAY VIDEO INFO -----------------------------------------
        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine("\n\n");
        } 
    }
}
