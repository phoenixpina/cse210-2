using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var saveAndLoad = new SaveAndLoad("goals.json");

        var createGoals = new CreateGoals();

        var goals = saveAndLoad.LoadGoals();

        while (true)
        {
            Console.WriteLine("\nThis is your goal tracking game! Select an option from below.");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record progress or report on a completed goal");
            Console.WriteLine("3. Display goals");
            Console.WriteLine("4. Display score");
            Console.WriteLine("5. Save goals to file");
            Console.WriteLine("6. Load goals from file");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(goals, createGoals);
                    break;
                case "2":
                    RecordEvent(goals);
                    break;
                case "3":
                    DisplayGoals(goals);
                    break;
                case "4":
                    DisplayUserScore(goals);
                    break;
                case "5":
                    saveAndLoad.SaveGoals(goals);
                    Console.WriteLine("Goals saved to file.");
                    break;
                case "6":
                    goals = saveAndLoad.LoadGoals();
                    Console.WriteLine("Goals loaded from file.");
                    break;
                case "7":
                    Console.WriteLine("Exiting program. Good luck out there!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose an option between 1-5.");
                    break;
            }
        }
    }

    static void CreateNewGoal(List<Goals> goals, CreateGoals createGoals)
    {
        Console.WriteLine("\nSelect goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal (a goal that is meant for continuous improvement)");
        Console.WriteLine("3. Checklist Goal (a goal that must be completed multiple times before being fully completed)");
        Console.WriteLine("4. Long-Term Goal (a goal that slowly becomes achieved as you report on your progress)");
        Console.Write("Enter your choice: ");
        string goalType = Console.ReadLine();

        Console.Write("Enter goal title: ");
        string title = Console.ReadLine();

        switch (goalType)
        {
            case "1":
                goals.Add(createGoals.CreateSimpleGoal(title));
                break;
            case "2":
                goals.Add(createGoals.CreateEternalGoal(title));
                break;
            case "3":
                Console.Write("Enter target amount for checklist goal: ");
                if (int.TryParse(Console.ReadLine(), out int targetCount))
                {
                    goals.Add(createGoals.CreateChecklistGoal(title, targetCount));
                }
                else
                {
                    Console.WriteLine("Invalid target amount. Goal was not created.");
                }
                break;
            case "4":
                Console.Write("Enter target progress count for long-term goal: ");
                if (int.TryParse(Console.ReadLine(), out int targetProgressCount))
                {
                    goals.Add(createGoals.CreateLongGoal(title, targetProgressCount));
                }
                else
                {
                    Console.WriteLine("Invalid target progress count. Goal was not created.");
                }
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal was not created.");
                break;
        }
    }

    static void RecordEvent(List<Goals> goals)
    {
        Console.Write("Enter goal title to record an event: ");
        string title = Console.ReadLine();

        var goal = goals.Find(g => g.Title == title);
        if (goal != null)
        {
            goal.RecordProgress();
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    static void DisplayGoals(List<Goals> goals)
    {
        Console.WriteLine("\nHere are your current goals:");
        foreach (var goal in goals)
        {
            string completionStatus = goal.IsCompleted ? "[X]" : "[ ]";
            if (goal is ChecklistGoals checklistGoal)
            {
                Console.WriteLine($"{completionStatus} {goal.Title} (Completed {checklistGoal.CurrentCount}/{checklistGoal.TargetCount} times)");
            }
            else
            {
                Console.WriteLine($"{completionStatus} {goal.Title}");
            }
        }
    }

    static void DisplayUserScore(List<Goals> goals)
    {
        int totalPoints = 0;
        foreach (var goal in goals)
        {
            totalPoints += goal.CalculatePoints();
        }
        Console.WriteLine($"\nScore: {totalPoints} points");
    }
}