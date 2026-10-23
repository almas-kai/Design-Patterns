namespace Abstract_Factory.Products;

public class IPS : IScreen
{
    public void Create()
    {
        Console.WriteLine("Creating the IPS screen type.");
    }
}