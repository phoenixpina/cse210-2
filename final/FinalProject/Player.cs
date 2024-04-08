public class Player
{
    public int _health;
    public int _damage; //damage dealt, so the "attack" stat
    public int _level;
    private Weapon _equippedWeapon;
    private Armor _equippedArmor;
    private List<Item> _inventory;

    public Player(int initialHealth, int initialDamage)
    {
        _health = initialHealth;
        _damage = initialDamage;
        //_level = 1; unused concept
    }

    public void EquipWeapon(Weapon weapon)
    {
        if (_equippedWeapon == null || weapon._attack > _equippedWeapon._attack)
        {
            _equippedWeapon = weapon;
            _damage += weapon._attack;
            Console.WriteLine($"Equipped {weapon._name}. Damage dealt increased by {_equippedWeapon._attack}.");
        }
    }

    public void EquipArmor(Armor armor)
    {
        if (_equippedArmor == null || armor._defense > _equippedArmor._defense)
        {
            _equippedArmor = armor;
            _health += armor._defense;
            Console.WriteLine($"Equipped {armor._name}. Health increased by {_equippedArmor._defense}.");
        }
    }

    public void ConsumeFood(Food food)
    {
        _health += food._heal;
        Console.WriteLine($"You ate {food._name}. Health restored by {food._heal} points.");
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            Console.WriteLine("You have been killed.");
        }
    }

    public void AddItem(Item item)
    {
        _inventory.Add(item);
        Console.WriteLine($"Added {item._name} to your inventory.");
    }
}
