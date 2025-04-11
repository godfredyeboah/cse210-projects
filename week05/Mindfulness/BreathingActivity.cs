using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration, string location) 
        : base("Breathing Exercise", "Breathe in... Hold... Breathe out.", duration, location) {}

    public void Start()
    {
        StartActivity();
        for (int i = 0; i < GetDuration() / 4; i++)
        {
            Console.WriteLine("\n🌬️ Breathe in...");
            ShowCountdown(5);

            Console.WriteLine("😌 Breathe out...");
            ShowCountdown(5);
        }
        EndActivity();
    }
}
