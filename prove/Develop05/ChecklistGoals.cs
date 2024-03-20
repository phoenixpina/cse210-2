public class ChecklistGoals : Goals
{
    public int TargetCount { get; private set; }
    public int CurrentCount { get; private set; }

    public ChecklistGoals(string title, int targetCount) : base(title)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
    }

    public override void RecordProgress()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            Console.WriteLine($"Recorded progress for {Title} ({CurrentCount}/{TargetCount})");
        }
        else
        {
            Console.WriteLine($"Goal {Title} completed!");
        }
    }

    public override int CalculatePoints()
    {
        int basePoints = CurrentCount * 3;

        int bonusPoints = CurrentCount == TargetCount ? 15 : 0;

        return basePoints + bonusPoints;
    }
}