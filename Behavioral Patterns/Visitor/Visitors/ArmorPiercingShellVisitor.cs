class ArmorPiercingShellVisitor : IVisitor
{
    public void Visit(LightTank lightTank)
    {
        Console.WriteLine("The armor piercing shell is visiting the light tank: ");
        lightTank.TakeDamage(30);
    }

    public void Visit(MediumTank mediumTank)
    {
        Console.WriteLine("The armor piercing shell is visiting the medium tank: ");
        mediumTank.TakeDamage(20);
    }

    public void Visit(HeavyTank heavyTank)
    {
        Console.WriteLine("The armor piercing shell is visiting the heavy tank: ");
        heavyTank.TakeDamage(10);
    }
}