using System;
using System.IO;
using System.Text.Json;

public class SaveLoad
{
    private readonly string saveFilePath = "player_data.json"; 

    public void Save(Player player)
    {
        try
        {
            string json = JsonSerializer.Serialize(player);
            File.WriteAllText(saveFilePath, json);
            Console.WriteLine("Player data saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving player data: {ex.Message}");
        }
    }

    public Player Load()
    {
        try
        {
            if (File.Exists(saveFilePath))
            {
                string json = File.ReadAllText(saveFilePath);
                return JsonSerializer.Deserialize<Player>(json);
            }
            else
            {
                Console.WriteLine("No saved player data found.");
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading player data: {ex.Message}");
            return null;
        }
    }
}