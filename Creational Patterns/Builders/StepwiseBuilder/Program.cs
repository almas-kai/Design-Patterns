using StepwiseBuilder.Builder;
using StepwiseBuilder.ProductToBuild;

namespace StepwiseBuilder;

class Program
{
    static void Main(string[] args)
    {
        Computer computer = ComputerBuilder.Create()
            .SetCPU("I7 14700K")
            .SetGPU("RTX 5080")
            .SetRAM("64GB")
            .SetSSD("2TB")
            .Build();

        Console.WriteLine(computer);
    }
}
