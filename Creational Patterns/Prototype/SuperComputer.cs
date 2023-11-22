using System;

namespace Prototype;

///<summary>
///  The class that utilizes the Prototype pattern.
///</summary>
public class SuperComputer : ISuperComputerPrototype
{
    public int MeaningOfLife { get; private set; }
    public object Clone()
    {
        return new SuperComputer { MeaningOfLife = this.MeaningOfLife };
    }
    public void FindMeaningOfLife()
    {
        Console.WriteLine("Calculating ...");
        // Simulate heavy computation.
        Thread.Sleep(3000);

        MeaningOfLife = 42;
    }
}