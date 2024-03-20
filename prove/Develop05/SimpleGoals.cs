public class SimpleGoals : Goals
{
    public SimpleGoals(string title) : base(title)
    {

    }

    public override int CalculatePoints()
    {
        return IsCompleted ? 5 : 0;
    }
}