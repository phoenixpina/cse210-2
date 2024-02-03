using System;

public class Journal
{
    string filename;
    public List<JournalEntry> entries = new List<JournalEntry>();
    JournalPrompts _prompts;

    public void addEntry()
    {
        JournalEntry entry = new JournalEntry();
        string newPrompt = _prompts.GeneratePrompt();
        entry.updatePrompt(newPrompt);
        Console.WriteLine($"{newPrompt}");

        string userResponse = Console.ReadLine();
        entry.updateEntry(userResponse);
        entry.updateDate(DateTime.Now.ToString());

        entry.Display();
        entries.Add(entry);
    } //A tutor helped me with this class one day, but a different day tutors were confused
        //about how to use this class, so now it's going unused. (I think. I don't think I call it anywhere.
        //but I'm gonna leave it here just in case.)

    public void addToList(JournalEntry entry)
    {
        entries.Add(entry);
    }

    public Journal()
    {
        JournalPrompts prompts = new JournalPrompts();
        _prompts = prompts;
    }
}
