public class Food : Item
{
    public int _heal;

    public Food(string Name, string Description, int HealingAmount) : base(Name, Description)
    {
        _heal = HealingAmount;
    }
}