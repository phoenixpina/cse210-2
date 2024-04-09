//base class for all enemy types.
//all enemy files will start with "E" so I can find them easily in the sidebar.

public class Enemy 
{
    public string _name;
    public int _health;
    public int _damage;
    public Rarity _enemyRarity;
    public enum Rarity
    {
        Common,
        Uncommon,
        Rare,
        UltraRare,
    }

    public Enemy (string Name, int Health, int Damage, Rarity rarity)
    {
        _name = Name;
        _health = Health;
        _damage = Damage;
        _enemyRarity = rarity; //due to forced naming conventions, the rarity parameter must be lowercase to avoid confusion
    }

   public void TakeDamage(int Damage)
   {
        _health -= Damage;
       // if (_health <= 0)
       // {
        //    Console.WriteLine($"{_name} has been defeated!");
        //}
   }

    public void DropItem(Player player)
    {
        double randomValue = new Random().NextDouble(); //I used AI to help with how to do drop rates
        switch(_enemyRarity)
        {
            case Rarity.Common:
            if (randomValue <= 0.3) //30% chance
            {
                player.EquipArmor(new Armor("Leather Armor", "Common Armor", 20));
            }
            else if (randomValue <= 0.6) //30% chance
            {
                player.EquipWeapon(new Weapon("10mm Pistol", "Common Weapon", 10));
            }
            else //40% chance
            {
                player.ConsumeFood(new Food("Blamco Mac and Cheese", "Common Food", 15));
            }
            break;

            case Rarity.Uncommon:
            if (randomValue <= 0.3)
            {
                player.EquipArmor(new Armor("Metal Armor", "Uncommon Armor", 45));
            }
            else if (randomValue <= 0.6)
            {
                player.EquipWeapon(new Weapon("Laser Pistol", "Uncommon Weapon", 25));
            }
            else
            {
                player.ConsumeFood(new Food("Caravan Lunch", "Uncommon Food", 40));
            }
            break;

            case Rarity.Rare:
            if (randomValue <= 0.3)
            {
                player.EquipArmor(new Armor("Robot Armor", "Rare Armor", 70));
            }
            else if (randomValue <= 0.6)
            {
                player.EquipWeapon(new Weapon("Legendary Big Iron", "Rare Weapon", 50));
            }
            else
            {
                player.ConsumeFood(new Food("Stimpack", "Rare Food", 50));
            }
            break;

            case Rarity.UltraRare:
            player.EquipArmor(new Armor("Power Armor", "UltraRare Armor", 500));
            player.EquipWeapon(new Weapon("Fat Man", "UltraRare Weapon", 200));
            player.ConsumeFood(new Food("Nuka Quantum", "UltraRare Food", 200));
            break;
        }
    }
}

