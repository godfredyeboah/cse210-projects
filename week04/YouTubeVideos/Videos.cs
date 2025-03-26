using System;

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