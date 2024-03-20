public class LongGoals : Goals
{
    //Difference between this and ChecklistGoals is that checklist is the same goal being repeatedly reported on as completed.
    //This is one goal that slowly gets completed as user reports on it
    public int TargetProgressCount { get; private set; }
    public int CurrentProgressCount { get; private set; }

    public LongGoals(string title, int targetProgressCount) : base(title)
    {
        TargetProgressCount = targetProgressCount;
        CurrentProgressCount = 0;
    }

    public override void RecordProgress()
    {
        if (CurrentProgressCount < TargetProgressCount)
        {
            CurrentProgressCount++;
            Console.WriteLine($"Recorded progress for {Title} ({CurrentProgressCount}/{TargetProgressCount})");
            if (CurrentProgressCount == TargetProgressCount)
            {
                IsCompleted = true;
                Console.WriteLine($"Goal {Title} completed!");
            }
        }
        else
        {
            Console.WriteLine($"Goal {Title} has already been completed!");
        }
    }

    public override int CalculatePoints()
    {
        return IsCompleted ? 20 : 0;
    }
}