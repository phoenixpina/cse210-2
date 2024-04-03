public class SuperMutant : Enemy
{
    public SuperMutant() : base("Super Mutant", 20, 5, Rarity.Common)
    {
        
    }
}

public class SuperMutantBrute : Enemy
{
    public SuperMutantBrute() : base("Super Mutant Brute", 50, 10, Rarity.Uncommon)
    {

    }
}

public class SuperMutantMaster : Enemy
{
    public SuperMutantMaster() : base("Super Mutant Master", 100, 20, Rarity.Rare)
    {
        
    }
}