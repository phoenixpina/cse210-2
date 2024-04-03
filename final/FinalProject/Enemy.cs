//base class for all enemy types.
//all enemy files will start with "E" so I can find them easily in the sidebar.

public class Enemy 
{
    public string _name;
    public int _health;
    public int _damage;
    public Rarity _enemyRarity;
    public enum Rarity //forced naming convention- must be uppercase
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
}
   
   
   
    //public void Attack (Player player) //haven't created neither Player nor Damage yet- has to be done in a different class
    //{
   //     player.TakeDamage(Damage);
    //}
