using System;

public class Combat
{
    private Player player;
    private Enemy enemy;

    public Combat(Player player, Enemy enemy)
    {
        this.player = player;
        this.enemy = enemy;
    }

    public void StartCombat()
    {
        Console.Clear();
        Console.WriteLine($"You encounter a {enemy._name}!");

        while (player._health > 0 && enemy._health > 0)
        {
            DisplayCombatOptions();
            int choice = GetUserChoice(1, 2);

            switch (choice)
            {
                case 1:
                    EnemyAttack();
                    AttackEnemy();
                    break;
                //case 2:
               //     Console.WriteLine("You use a healing item.");
                //    break;
                case 2:
                    Console.WriteLine("You retreat to survive another day.");
                    Console.WriteLine("");
                    return; 
            }
        }

        if (player._health <= 0)
        {
            Console.WriteLine("You were killed. May someone find your tags for remembrance.");
            Console.WriteLine("");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine($"You killed the {enemy._name}!");
            enemy.DropItem(player);
            Console.WriteLine("");
        }
    }

    private void DisplayCombatOptions()
    {
        Console.WriteLine("1. Attack");
        //Console.WriteLine("2. Use healing item");
        Console.WriteLine("2. Run away");
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

    private void AttackEnemy()
    {
        int damageDealt = player._damage;
        enemy.TakeDamage(damageDealt);
        Console.WriteLine($"You deal {damageDealt} damage to the {enemy._name}.");
    }

    private void EnemyAttack()
    {
        int damageTaken = enemy._damage;
        player.TakeDamage(damageTaken);
        Console.WriteLine("");
        Console.WriteLine($"The {enemy._name} attacks! You take {damageTaken} damage.");
        Console.WriteLine($"Your remaining health: {player._health}");
    }
}
