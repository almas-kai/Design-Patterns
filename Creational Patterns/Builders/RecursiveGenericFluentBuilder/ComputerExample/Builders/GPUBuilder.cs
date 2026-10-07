namespace RecursiveGenericFluentBuilder.ComputerExample;

public class GPUBuilder<TSelf>
    : CPUBuilder<TSelf>
    where TSelf : GPUBuilder<TSelf>
{
    public TSelf SetGPU(string gpu)
    {
        Computer.GPU = gpu;
        return (TSelf)this;
    }
}