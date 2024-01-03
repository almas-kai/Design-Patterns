namespace Builder;

class Program
{
    static void Main(string[] args)
    {
        (new MainDirector(new SimpleComputerBuilder())).Build().ListAllComponents();
    }
}
