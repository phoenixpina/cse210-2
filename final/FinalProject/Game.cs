using System;
using System.IO;
using System.Text.Json;

public class Game
{
    private Player player;
    private SaveLoad SaveAndLoad;
    private readonly string saveFilePath = "player_data.json";
    private int _enemiesDefeated = 0;
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
        Console.WriteLine("");
        Console.WriteLine("Welcome to New Alamogordo.");
        Console.WriteLine("You are a Brotherhood of Steel Initiate, on a mission to investigate the old city of Alamogordo, New Mexico.");
        Console.WriteLine("The land is more hostile than expected, and you were separated from the others.");
        Console.WriteLine("Fight your way back to the airship. You'll have to defeat at least 10 enemies to clear a path.");
        Console.WriteLine("But remember: there's no shame in running and living to see another day.");
        Console.WriteLine("Fight weaker enemies, and take the weapons and armor they drop to get stronger.");
        Console.WriteLine("Good luck, Initiate. Ad Victoriam.");
        DisplayMainMenu();
    }

    private void DisplayMainMenu()
    {
        //int _enemiesDefeated = 0;
        do
        {
            Console.WriteLine("1. Fight a random enemy");
            Console.WriteLine("2. Save progress");
            Console.WriteLine("3. Get to the airship");
            Console.WriteLine("4. Quit the game");

            int choice = GetUserChoice(1, 4);

            switch (choice)
            {
                case 1:
                    FightRandomEnemy();
                    break;
                case 2:
                    SavePlayerData();
                    break;
                case 3:
                    if (_enemiesDefeated >= 10)
                    {
                        Console.Clear();
                        Console.WriteLine("You've made it back to the base airship. Well done.");
                        Console.WriteLine("You showed us what you're made of this day.");
                        Console.WriteLine("There may be a promotion to Knight in it for you.");
                        Console.WriteLine("But as for now, it's time to return to the chapter base.");
                        Console.WriteLine("Ad Victoriam.");
                        Console.WriteLine("");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("There's still too many enemies in your way. You need to kill at least 10 enemies to escape.");
                    }
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
        while (true);
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
        Enemy[] possibleEnemies = { new SuperMutant(), new FeralGhoul(), new Raider(), 
        new SuperMutantBrute(), new WitheredFeralGhoul(), new RaiderPsycho(),
        new SuperMutantMaster(), new GlowingOne(), new RaiderVeteran(), new Behemoth()};

        Random random = new Random();
        int randomIndex = random.Next(possibleEnemies.Length);
        Enemy randomEnemy = possibleEnemies[randomIndex];
        Combat combat = new Combat(player, randomEnemy);
        combat.StartCombat();
        _enemiesDefeated ++;
    }

    //private void ContinueToNextArea()
    //{
        //unused method
    //}

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
