using System;
using System.Threading;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menu for the user to choose an activity
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Select an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        StartBreathingActivity();
                        break;

                    case "2":
                        StartReflectionActivity();
                        break;

                    case "3":
                        StartListingActivity();
                        break;

                    case "4":
                        Console.WriteLine("Thank you for using the Mindfulness App. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid activity.");
                        break;
                }
            }
        }

        static void StartBreathingActivity()
        {
            BreathingActivity breathingActivity = new BreathingActivity();
            breathingActivity.Start();
        }

        static void StartReflectionActivity()
        {
            ReflectionActivity reflectionActivity = new ReflectionActivity();
            reflectionActivity.Start();
        }

        static void StartListingActivity()
        {
            ListingActivity listingActivity = new ListingActivity();
            listingActivity.Start();
        }
    }
}
