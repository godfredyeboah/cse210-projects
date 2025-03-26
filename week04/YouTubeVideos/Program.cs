using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args) // Updated with args
    {
        // Creating a list of videos
        List<Video> videos = new List<Video>();

        // Creating video objects and adding comments
        Video video1 = new Video("Learn C# in 10 Minutes", "TechGuru", 600);
        video1.AddComment("Alice", "Great tutorial! Helped me a lot.");
        video1.AddComment("Bob", "Can you make one for advanced topics?");
        video1.AddComment("Charlie", "Very clear explanation, thanks!");
        video1.AddComment("Godfred", "Awesome! This tutorial makes a lot of sense.");

        Video video2 = new Video("Understanding OOP in C#", "CodeWithSam", 900);
        video2.AddComment("Dave", "I finally understand OOP, thanks!");
        video2.AddComment("Eve", "What about interfaces?");
        video2.AddComment("Frank", "Awesome content as always!");

        Video video3 = new Video("C# Async Programming", "DevMaster", 720);
        video3.AddComment("Grace", "This is exactly what I needed.");
        video3.AddComment("Hank", "Can you provide some example projects?");
        video3.AddComment("Ivy", "Very informative, thank you!");
        video3.AddComment("Yeboah", "Great! I can't wait for our next lesson.");

        // Adding videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Displaying video information
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
