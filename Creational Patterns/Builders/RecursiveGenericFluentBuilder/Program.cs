using RecursiveGenericFluentBuilder.ComputerExample;

namespace RecursiveGenericFluentBuilder;

class Program
{
    static void Main(string[] args)
    {
        string mySpecs = Computer.New
            .SetSSD("Adata Legend 860 1TB")
            .SetRAM("32Gb 6400MT/s")
            .SetCPU("I7 14700K")
            .SetGPU("RTX 5070TI 16Gb")
            .Build()
            .ToString();

        Console.WriteLine(mySpecs);
    }
}
