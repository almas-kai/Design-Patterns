namespace Factory_Method;

class Program
{
    static void Main(string[] args)
    {
        IVehicle myVehicle = ProduceAnInstance(new CarFactory());
        myVehicle.Move();

        ProduceAnInstance(new TruckFactory()).Move();
    }
    private static IVehicle ProduceAnInstance(AbstractVehicleFactory type){
        return type.CreateVehicle();
    }
}
