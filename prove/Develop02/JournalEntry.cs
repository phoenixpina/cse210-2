using System;
using System.Data;

public class JournalEntry
{
    public string prompt;
    public string date;
    public string entry;

    public void updatePrompt(string userprompt) 
    {
        prompt = userprompt;
    }

    public void updateDate(string userDate)
    {
        date = userDate;
    }

    public void updateEntry(string userEntry)
    {
        entry = userEntry;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {date} - Prompt: {prompt}: {entry}");
    }
}