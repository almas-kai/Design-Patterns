namespace Factory_Method;

public class CarFactory : AbstractVehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Car();
    }
}