using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Start()  // Renamed from StartBreathing to Start to follow consistency.
    {
        base.Start();

        Console.WriteLine("\n🌬️ Breathe in...");
        ShowCountdown(5);

        Console.WriteLine("😌 Breathe out...");
        ShowCountdown(5);

        EndActivity();
    }
}
