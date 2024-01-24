namespace Abstract_Factory.Products;

public class Amoled : IScreen
{
    public void Create()
    {
        Console.WriteLine("Creating the AMOLED screen type.");
    }
}