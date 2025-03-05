// using System;

// class Program
// {
//     static void Main()
//     {
//         // For Part 1 without loop, where the user specifies the number...
//         // Ask the user for the magic number
//         Console.Write("What is the magic number? ");
//         int magicNumber = int.Parse(Console.ReadLine());

//         // Ask the user for a guess
//         Console.Write("What is your guess? ");
//         int guess = int.Parse(Console.ReadLine());

//         // Check if the guess is too high, too low, or correct
//         if (guess < magicNumber)
//         {
//             Console.WriteLine("Higher");
//         }
//         else if (guess > magicNumber)
//         {
//             Console.WriteLine("Lower");
//         }
//         else
//         {
//             Console.WriteLine("You guessed it!");
//         }
//     }
// }








using System;

class Program
{
    static void Main(string[] args)
    {
        // For Parts 1 and 2 with loop, where the user specified the number...
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        
        // // For Part 3, where we use a random number
        // // To use part 3, comment the code ("for part 1 and 2") up there and uncomment this whole section. 
        // Random randomGenerator = new Random();
        // int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // We could also use a do-while loop here...
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}