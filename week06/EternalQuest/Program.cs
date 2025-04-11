using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new();
        gm.LoadGoals("goals.txt");

        string choice = "";
        while (choice != "6")
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n*** Eternal Quest ***");
            Console.ResetColor();
            Console.WriteLine($"Score: {gm.Score}");
            Console.WriteLine("\n1. Create Goal\n2. List Goals\n3. Record Progress\n4. Save\n5. Load\n6. Quit");
            Console.Write("Choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1": gm.CreateGoal(); break;
                case "2": gm.ShowGoals(); break;
                case "3": gm.RecordProgress(); break;
                case "4": gm.SaveGoals("goals.txt"); break;
                case "5": gm.LoadGoals("goals.txt"); break;
                case "6": Console.WriteLine("Goodbye!"); break;
                default: Console.WriteLine("Invalid input."); break;
            }
        }
    }
}