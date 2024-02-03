using System;

public class SaveAndLoad
{
    public void SaveEntry(List<JournalEntry> entryList, string filename) 
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in entryList)
            {
                outputFile.WriteLine($"Date: {entry.date}, - Prompt: {entry.prompt}, {entry.entry}");
            }
        }
    }

    public void LoadEntry (string userFile)
    {
        string[] lines = System.IO.File.ReadAllLines(userFile);

        foreach (string line in lines)
        {
            //Console.WriteLine(line);
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
            string whatever = parts[2];
            Console.WriteLine($"{firstName}, {lastName}, {whatever}");
        }
    }
}
