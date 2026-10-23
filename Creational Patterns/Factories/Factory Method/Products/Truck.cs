namespace Factory_Method;

public class Truck : IVehicle
{
    public void Move()
    {
        Console.WriteLine("Truck is moving.");
    }
}