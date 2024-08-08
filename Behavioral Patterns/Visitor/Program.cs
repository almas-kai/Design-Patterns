namespace Visitor;

class Program
{
    public static void VisitAllTanks(List<TankAbstract> tanks, IVisitor visitor)
    {
        foreach (TankAbstract tank in tanks)
        {
            tank.Accept(visitor);
        }
    }
    static void Main()
    {
        List<TankAbstract> tanks = new List<TankAbstract>(){
            new LightTank(100),
            new MediumTank(200),
            new HeavyTank(300)
        };

        IVisitor visitor = new ArmorPiercingShellVisitor();

        Console.WriteLine("HP before hit: ");
        foreach (TankAbstract tank in tanks)
        {
            Console.WriteLine(tank.Health);
        }

        Console.WriteLine("HP after hit: ");
        VisitAllTanks(tanks, visitor);
        foreach (TankAbstract tank in tanks)
        {
            Console.WriteLine(tank.Health);
        }
    }
}
