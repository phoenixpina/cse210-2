public class Player
{
    public int _health;
    public int _damage; //damage dealt, so attack
    public int _level;

    public Player(int initialHealth, int initialDamage)
    {
        _health = initialHealth;
        _damage = initialDamage;
        //_level = 1; 
    }

    public void EquipWeapon(Weapon weapon)
    {
        _damage += weapon._attack;
    }

    public void EquipArmor(Armor armor)
    {
        _health += armor._defense;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            Console.WriteLine("You have been killed.");
        }
    }
}

//player.EquipWeapon(laserGun);
//player.EquipArmor(powerArmor);

    //public void LevelUp()
   // {
   //     _level++; //I may choose to scrap level and just do stats like Monster Hunter
   // }