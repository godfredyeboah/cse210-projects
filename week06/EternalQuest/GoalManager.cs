using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GoalManager
{
    public List<Goal> Goals { get; private set; } = new();
    public int Score { get; private set; } = 0;
    private int _lastMilestone = 0;

    public void CreateGoal()
    {
        Console.WriteLine("Choose goal type:\n1. Simple\n2. Eternal\n3. Checklist");
        string input = Console.ReadLine();
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        int points = GetValidInt("Points: ");

        switch (input)
        {
            case "1":
                Goals.Add(new SimpleGoal(name, desc, points));
                break;
            case "2":
                Goals.Add(new EternalGoal(name, desc, points));
                break;
            case "3":
                int target = GetValidInt("Target count: ");
                int bonus = GetValidInt("Bonus points: ");
                Goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    public void RecordProgress()
    {
        if (Goals.Count == 0) {
            Console.WriteLine("No goals yet!");
            return;
        }

        Console.WriteLine("Select goal to record:");
        for (int i = 0; i < Goals.Count; i++)
        {
            Console.ForegroundColor = Goal.GetColorForGoal(Goals[i]);
            Console.WriteLine($"{i + 1}. {Goals[i].GetStatus()}");
            Console.ResetColor();
        }

        int choice = GetValidInt("Choice: ") - 1;
        if (choice >= 0 && choice < Goals.Count)
        {
            int gained = Goals[choice].RecordEvent();
            Score += gained;

            Console.WriteLine(gained > 0 ? $"You gained {gained} points!" : "Already completed.");
            ShowLevelUp();
        }
        else Console.WriteLine("Invalid goal.");
    }

    public void ShowGoals()
    {
        foreach (Goal g in Goals)
        {
            Console.ForegroundColor = Goal.GetColorForGoal(g);
            Console.WriteLine(g.GetStatus());
            Console.ResetColor();
        }
    }

    public void SaveGoals(string file)
    {
        using StreamWriter writer = new(file);
        writer.WriteLine(Score);
        writer.WriteLine(_lastMilestone);
        foreach (var goal in Goals)
            writer.WriteLine(goal.GetSaveString());
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("No saved goals file found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        Goals.Clear(); // Clear existing goals

        if (lines.Length > 1)
        {
            Score = int.Parse(lines[0]);
            _lastMilestone = int.Parse(lines[1]);

            foreach (string line in lines.Skip(2)) // Skip Score and Milestone
            {
                string[] parts = line.Split("|");
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (type == "SimpleGoal")
                {
                    bool completed = bool.Parse(parts[4]);
                    Goals.Add(new SimpleGoal(name, description, points, completed));
                }
                else if (type == "EternalGoal")
                {
                    Goals.Add(new EternalGoal(name, description, points));
                }
                else if (type == "ChecklistGoal")
                {
                    int targetCount = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    int completedCount = int.Parse(parts[6]);
                    int lastMilestone = parts.Length > 7 ? int.Parse(parts[7]) : 0;

                    ChecklistGoal cg = new ChecklistGoal(name, description, points, targetCount, bonus);
                    cg.SetLastMilestone(lastMilestone);

                    while (completedCount-- > 0)
                    {
                        cg.RecordEvent();
                    }

                    Goals.Add(cg);
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Goals loaded successfully!");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("File is empty.");
        }
    }

    private void ShowLevelUp()
    {
        if (Score / 1000 > _lastMilestone)
        {
            _lastMilestone = Score / 1000;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n🎉 You've leveled up to Milestone {_lastMilestone}! 🎉\n");
            Console.ResetColor();
        }
    }

    private int GetValidInt(string prompt)
    {
        int value;
        Console.Write(prompt);
        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Invalid input. Try again: ");
        }
        return value;
    }
}
