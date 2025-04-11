using System;
using System.Threading;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Activities");
                Console.WriteLine("1. Breathing Exercise");
                Console.WriteLine("2. Reflection Exercise");
                Console.WriteLine("3. Listing Exercise");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an activity: ");

                string choice = Console.ReadLine();
                Console.Clear();

                if (choice == "4") break;

                Console.Write("Enter duration (seconds): ");
                int duration = int.Parse(Console.ReadLine());

                Console.Write("Enter location (e.g., home, park, office): ");
                string location = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        new BreathingActivity(duration, location).Start();
                        break;
                    case "2":
                        new ReflectionActivity(duration, location).Start();
                        break;
                    case "3":
                        new ListingActivity(duration, location).Start();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}
