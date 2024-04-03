public class Weapon : Inventory
{
    public int _attack;
    public Weapon(string Name, int Attack) : base(Name)
    {
        _attack = Attack;
    }
}