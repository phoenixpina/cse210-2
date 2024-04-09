public class SuperMutant : Enemy
{
    public SuperMutant() : base("Super Mutant (Common)", 20, 10, Rarity.Common)
    {
        
    }
}

public class SuperMutantBrute : Enemy
{
    public SuperMutantBrute() : base("Super Mutant Brute (Uncommon)", 50, 15, Rarity.Uncommon)
    {

    }
}

public class SuperMutantMaster : Enemy
{
    public SuperMutantMaster() : base("Super Mutant Master (Rare)", 100, 25, Rarity.Rare)
    {
        
    }
}

public class Behemoth : Enemy
{
    public Behemoth() : base("Behemoth (Ultra Rare)", 150, 40, Rarity.UltraRare)
    {
        //in order to win (without the Behemoth's rewards, of course),
        //you'd have to have the Big Iron equipped with more than 120 health at the start of battle
    }
}