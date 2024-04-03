public class Armor : Inventory
{
    public int _defense;
    public Armor(string Name, int Defense) : base(Name)
    {
        _defense = Defense;
    }
}

//example usage:
//var powerArmor = new Armor("Power Armor", 100);