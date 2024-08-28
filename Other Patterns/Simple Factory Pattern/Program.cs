namespace Simple_Factory_Pattern;

class Program
{
    static void Main()
    {
        IProduct myPhone = Factory.GetProduct("phone");
        Console.WriteLine(myPhone.GetProductDescription());

        IProduct myComputer = Factory.GetProduct("computer");
        Console.WriteLine(myComputer.GetProductDescription());
    }
}
