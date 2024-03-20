public class CreateGoals
{
    public SimpleGoals CreateSimpleGoal(string title)
    {
        return new SimpleGoals(title);
    }

    public EternalGoals CreateEternalGoal(string title)
    {
        return new EternalGoals(title);
    }

    public ChecklistGoals CreateChecklistGoal(string title, int targetCount)
    {
        return new ChecklistGoals(title, targetCount);
    }

    public LongGoals CreateLongGoal(string title, int targetProgressCount)
    {
        return new LongGoals(title, targetProgressCount);
    }
}