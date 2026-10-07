namespace RecursiveGenericFluentBuilder.ComputerExample;

public class RAMBuilder<TSelf>
    : GPUBuilder<TSelf>
    where TSelf : RAMBuilder<TSelf>
{
    public TSelf SetRAM(string ram)
    {
        Computer.RAM = ram;
        return (TSelf)this;
    }
}