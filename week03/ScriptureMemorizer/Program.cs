using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture reference
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        
        // Create a scripture with text
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding.");

        // Main loop
        while (true)
        {
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideWords(2); // Hide 2 words at a time

            if (scripture.IsCompletelyHidden())
            {
                scripture.Display();
                Console.WriteLine("\nAll words are hidden. Program ending...");
                break;
            }
        }
    }
}