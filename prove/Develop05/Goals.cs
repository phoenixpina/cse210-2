public abstract class Goals
{
    public string Title { get; set; }
    public bool IsCompleted { get; protected set; }

    public Goals(string title)
    {
        Title = title;
        IsCompleted = false;
    }

    public abstract int CalculatePoints();

    public virtual void RecordProgress()
    {
        Console.WriteLine($"Recorded progress for {Title}");
    }
}