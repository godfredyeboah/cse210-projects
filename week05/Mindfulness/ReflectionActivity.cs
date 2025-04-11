using System;
using System.Threading;

public class ReflectionActivity : Activity
{
    private string[] _prompts = { 
        "Think of a time when you overcame a challenge.", 
        "Remember a moment when you felt truly happy.",
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless." 
    };

    public ReflectionActivity(int duration, string location) 
        : base("Reflection Exercise", "Think deeply about the given prompt.", duration, location) {}

    public void Start()
    {
        StartActivity();
        Random rand = new Random();
        Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Length)]}\n");
        ShowSpinner(GetDuration());
        EndActivity();
    }
}
