using System;
using System.IO;
using System.Text.Json;

public class Game
{
    private Player player;
    private SaveLoad SaveAndLoad;
    private readonly string saveFilePath = "player_data.json";
    public Game()
    {
        //Player player = CreateNewPlayer();
        //LoadPlayerData();
        //SaveAndLoad = new SaveLoad();
        player = LoadPlayerData() ?? CreateNewPlayer();
    }

    public void Start()
    {
        //Player player = CreateNewPlayer();
        Console.WriteLine("Welcome to New Alamogordo.");
        DisplayMainMenu();
    }

    private void DisplayMainMenu()
    {
        Console.WriteLine("1. Fight a random enemy");
        Console.WriteLine("2. Continue to the next area");
        Console.WriteLine("3. Save progress");
        Console.WriteLine("4. Quit the game");

        int choice = GetUserChoice(1, 4);

        switch (choice)
        {
            case 1:
                FightRandomEnemy();
                break;
            case 2:
                ContinueToNextArea();
                break;
            case 3:
                SavePlayerData();
                break;
            case 4:
                Environment.Exit(0);
                break;
        }
    }

    private int GetUserChoice(int min, int max)
    {
        int choice;
        while (true)
        {
            Console.Write($"Enter your choice ({min}-{max}): ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice >= min && choice <= max)
                    return choice;
                else
                    Console.WriteLine($"Invalid input. Please enter a number between {min} and {max}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
    private Player CreateNewPlayer()
    {
        int InitialHealth = 100;
        int InitialDamage = 10;
        Player newPlayer = new Player(InitialHealth, InitialDamage);
        return newPlayer;
    }

    private void FightRandomEnemy()
    {
        Enemy[] possibleEnemies = { new SuperMutant(), new FeralGhoul(), new Raider() };
        Random random = new Random();
        int randomIndex = random.Next(possibleEnemies.Length);
        Enemy randomEnemy = possibleEnemies[randomIndex];
        //Console.WriteLine($"You encounter a {randomEnemy._name}!");
        Combat combat = new Combat(player, randomEnemy);
        combat.StartCombat();
    }

    private void ContinueToNextArea()
    {

    }

    private void SavePlayerData()
    {
        SaveAndLoad.Save(player);
    }

    private Player LoadPlayerData()
    {
        try
        {
            if (File.Exists(saveFilePath))
            {
                string json = File.ReadAllText(saveFilePath);
                //player = JsonSerializer.Deserialize<Player>(json);
                return JsonSerializer.Deserialize<Player>(json);
            }
            else
            {
                Console.WriteLine("No saved player data found.");
                return CreateNewPlayer();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading player data: {ex.Message}");
            return null;
        }
    }
}
