using System;
using System.Threading;

class ListingActivity : Activity
{
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
    {
    }

    public override void Start()
    {
        base.Start();

        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can.");
        ShowCountdown(_duration);

        // Prompt for listing items
        string prompt = "List as many things as you can think of related to 'Who are people that you appreciate?'";
        Console.WriteLine(prompt);

        // Start the listing process
        ListItems(_duration);

        // Ending message
        Console.WriteLine("Good job! You've completed the Listing Activity!");
        EndActivity();
    }

    private void ListItems(int duration)
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int itemCount = 0;

        // Allow user to keep listing items until the time is up
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item (or type 'done' to finish): ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "done")
                break;

            itemCount++;
        }

        // Show how many items they listed
        Console.WriteLine($"You listed {itemCount} items.");
    }
}
