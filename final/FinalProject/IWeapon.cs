public class Weapon : Item
{
    public int _attack;
    public Weapon(string Name, string Description, int Attack) : base(Name, Description)
    {
        _attack = Attack;
    }
}