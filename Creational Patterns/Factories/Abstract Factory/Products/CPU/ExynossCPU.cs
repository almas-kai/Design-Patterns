namespace Abstract_Factory.Products;

public class ExynossCPU : IProcessor
{
    public void Embed()
    {
        Console.WriteLine("Embedding the Exynoss CPU.");
    }
}