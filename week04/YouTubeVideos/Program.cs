using System;
using System.Collections.Generic;

// Comment class to store name and text of a comment
class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

// Video class to store title, author, length, and comments
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    // Method to add a comment to the video
    public void AddComment(string name, string text)
    {
        comments.Add(new Comment(name, text));
    }

    // Method to get the number of comments
    public int GetCommentCount()
    {
        return comments.Count;
    }

    // Method to display video details
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");

        foreach (var comment in comments)
        {
            Console.WriteLine($" - {comment.Name}: {comment.Text}");
        }
        Console.WriteLine();
    }
}

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
