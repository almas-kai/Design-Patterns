namespace RecursiveGenericFluentBuilder.ComputerExample;

public class CPUBuilder<TSelf>
    : BuilderAbstract
    where TSelf : CPUBuilder<TSelf>
{
    public TSelf SetCPU(string cpu)
    {
        Computer.CPU = cpu;
        return (TSelf) this;
    }
}