using System;
using System.IO;
using System.Threading;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected string _location;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _location = GetLocation();
    }

    public virtual void Start()  // Changed from StartActivity to Start to maintain consistency.
    {
        Console.Clear();
        Console.WriteLine($"🌟 {_name} Activity 🌟");
        Console.WriteLine($"\n{_description}\n");

        Console.Write("⏳ Enter duration (seconds): ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\n🛑 Get ready...");
        ShowSpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("\n🎉 Great job! You completed the activity.");
        Console.WriteLine($"📌 Activity: {_name} | ⏳ Duration: {_duration}s | 📍 Location: {_location}");
        ShowSpinner(3);
        LogActivity();
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write($"\r{spinner[i % 4]}");
            Thread.Sleep(250);
        }
        Console.Write("\r ");
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r⏳ {i} ");
            Thread.Sleep(1000);
        }
        Console.Write("\r    \r"); // Clears the countdown text
    }

    protected void LogActivity()
    {
        string logEntry = $"{DateTime.Now} | {_name} | {_duration}s | {_location}";
        File.AppendAllText("ActivityLog.txt", logEntry + Environment.NewLine);
    }

    private string GetLocation()
    {
        return "Accra, Ghana"; // Placeholder, could integrate actual location API in future
    }
}
