namespace Factory_Method;

public class TruckFactory : AbstractVehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Truck();
    }
}