public class Reference
{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int StartVerse { get; private set; }
    public int EndVerse { get; private set; }

    public Reference(string reference)
    {
        string[] bookPart = reference.Split(' ');
        if (bookPart.Length > 2)
        {
            Book = string.Join(' ', bookPart, 0, 2);
        }
        else
        {
            Book = bookPart[0];
        }

        string[] chapterPart = bookPart[1].Split(':');
        Chapter = int.Parse(chapterPart[0]);
        string[] versePart = chapterPart[1].Split('-');
        StartVerse = int.Parse(versePart[0]);
        EndVerse = versePart.Length > 1 ? int.Parse(versePart[1]) : StartVerse;
    }

    public override string ToString()
    {
        return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
    }
}