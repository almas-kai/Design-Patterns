namespace Factory_Method;

public class Car : IVehicle
{
    public void Move()
    {
        Console.WriteLine("Car is moving.");
    }
}