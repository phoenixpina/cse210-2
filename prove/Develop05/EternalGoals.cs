public class EternalGoals : Goals
{
    public EternalGoals(string title) : base(title)
    {

    }

    public override int CalculatePoints()
    {
        return 10;
    }
}