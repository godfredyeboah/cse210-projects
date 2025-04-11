using System;
using System.IO;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private string _location;

    public Activity(string name, string description, int duration, string location)
    {
        _name = name;
        _description = description;
        _duration = duration;
        _location = location;
    }

    // Getters (Encapsulation)
    protected string GetName() => _name;
    protected string GetDescription() => _description;
    protected int GetDuration() => _duration;
    protected string GetLocation() => _location;

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Starting: {GetName()}");
        Console.WriteLine(GetDescription());
        Console.WriteLine($"Duration: {GetDuration()} seconds\n");
        ShowCountdown(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("\nGood job! You have completed the activity.");
        LogActivity();
        ShowCountdown(2);
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rStarting in {i}...");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowSpinner(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        for (int i = 0; i < seconds * 2; i++)
        {
            Console.Write($"\r{spinner[i % 4]}");
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }

    private void LogActivity()
    {
        string logEntry = $"{DateTime.Now}: Completed {GetName()} at {GetLocation()} for {GetDuration()} seconds.";
        File.AppendAllText("ActivityLog.txt", logEntry + Environment.NewLine);
    }
}
