using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class SaveAndLoad
{
    private readonly string filePath; 

    public SaveAndLoad(string filePath)
    {
        this.filePath = filePath;
    }

    public void SaveGoals(List<Goals> goals)
    {
        try
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true 
            };

            string json = JsonSerializer.Serialize(goals, options);
            File.WriteAllText(filePath, json);

            Console.WriteLine($"Goals saved to {filePath}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}"); //I actually really don't know if this error message works.
        }                                                              //I don't know how to test it.
    }

    public List<Goals> LoadGoals()
    {
        try
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Goals>>(json);
            }
            else
            {
                Console.WriteLine("No saved goals found.");
                return new List<Goals>();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
            return new List<Goals>();
        }
    }
}