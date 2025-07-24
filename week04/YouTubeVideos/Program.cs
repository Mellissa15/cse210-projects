using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("How to Bake Bread", "Chef Mel", 540);
        v1.AddComment(new Comment("Anna", "Loved this recipe!"));
        v1.AddComment(new Comment("Ben", "I tried it and it came out amazing."));
        v1.AddComment(new Comment("Tina", "Easy to follow!"));

        // Video 2
        Video v2 = new Video("Beginner Yoga Routine", "FlexiFit", 620);
        v2.AddComment(new Comment("John", "Feeling great after this!"));
        v2.AddComment(new Comment("Ella", "Perfect for my morning routine."));
        v2.AddComment(new Comment("Zara", "Thanks for sharing this."));

        // Video 3
        Video v3 = new Video("C# OOP Basics", "Code Guru", 720);
        v3.AddComment(new Comment("Leo", "So helpful and clear."));
        v3.AddComment(new Comment("Nina", "I'm finally getting it!"));
        v3.AddComment(new Comment("Ahmed", "Thanks a lot!"));

        // Add to list
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        // Display all
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine(new string('-', 40));
        }
    }
}
