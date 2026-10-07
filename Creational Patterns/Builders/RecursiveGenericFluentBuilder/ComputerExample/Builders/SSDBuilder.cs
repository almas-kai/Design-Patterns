namespace RecursiveGenericFluentBuilder.ComputerExample;

public class SSDBuilder<TSelf>
    : RAMBuilder<TSelf>
    where TSelf : SSDBuilder<TSelf>
{
    public TSelf SetSSD(string ssd)
    {
        Computer.SSD = ssd;
        return (TSelf)this;
    }
}