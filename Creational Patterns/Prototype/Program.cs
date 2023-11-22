namespace Prototype;

class Program
{
    static void Main(string[] args)
    {
        SuperComputer sp = new SuperComputer();
        sp.FindMeaningOfLife();
        Console.WriteLine(sp.MeaningOfLife);
        SuperComputer clone = (SuperComputer)sp.Clone();
        Console.WriteLine(clone.MeaningOfLife);
        Console.WriteLine(clone == sp);
    }
}
