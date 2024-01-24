namespace Abstract_Factory.Products;

public class AppleMCPU : IProcessor
{
    public void Embed()
    {
        Console.WriteLine("Embedding the Apple M CPU.");
    }
}