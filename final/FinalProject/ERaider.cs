public class Raider : Enemy
{
    public Raider() : base("Raider", 15, 5, Rarity.Common)
    {
        
    }
}

public class RaiderPsycho : Enemy
{
    public RaiderPsycho() : base("Raider Psycho", 35, 10, Rarity.Uncommon)
    {

    }
}

public class RaiderVeteran : Enemy
{
    public RaiderVeteran() : base("Raider Veteran", 70, 20, Rarity.Rare)
    {
        
    }
}