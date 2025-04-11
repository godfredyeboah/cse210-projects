using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private string[] _prompts = { 
        "List the things you are grateful for today.", 
        "List some goals you want to achieve." 
    };

    public ListingActivity(int duration, string location) 
        : base("Listing Exercise", "Write down as many things as you can related to the prompt.", duration, location) {}

    public void Start()
    {
        StartActivity();
        Random rand = new Random();
        Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Length)]}\n");
        Console.WriteLine("You have " + GetDuration() + " seconds to write your answers.");
        
        List<string> userResponses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("→ ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
                userResponses.Add(response);
        }

        Console.WriteLine($"\nYou listed {userResponses.Count} items.");
        EndActivity();
    }
}
