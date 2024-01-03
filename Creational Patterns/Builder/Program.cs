namespace Builder;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of a builder.
        IBuilder builder = new SimpleComputerBuilder();

        // Create an instance of a director, and pass the builder to it.
        MainDirector director = new MainDirector(builder);

        // Build your product (Computer).
        Computer product = director.Build();

        // List the components.
        product.ListAllComponents();

        // The equivalent, but shorter version.
        // (new MainDirector(new SimpleComputerBuilder())).Build().ListAllComponents();
    }
}
