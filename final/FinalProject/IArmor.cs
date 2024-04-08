public class Armor : Item
{
    public int _defense;
    public Armor(string Name, string Description, int Defense) : base(Name, Description)
    {
        _defense = Defense;
    }
}

//example usage:
//var powerArmor = new Armor("Power Armor", 100);