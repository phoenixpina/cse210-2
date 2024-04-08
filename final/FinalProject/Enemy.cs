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
        if (_health <= 0)
        {
            Console.WriteLine($"{_name} has been defeated!");
        }
   }

    public void DropItem(Player player)
    {
        double randomValue = new Random().NextDouble();
        switch(_enemyRarity)
        {
            case Rarity.Common:
            if (randomValue <= 0.3)
            {
                player.AddItem(new Armor("Common Armor", "Leather Armor", 10));
            }
            else if (randomValue <= 0.6)
            {
                player.AddItem(new Weapon("Common Weapon", "10mm Pistol", 10));
            }
            break;
        }
    }
}
   
   
   
    //public void Attack (Player player) //haven't created neither Player nor Damage yet- has to be done in a different class
    //{
   //     player.TakeDamage(Damage);
    //}
