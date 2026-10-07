namespace RecursiveGenericFluentBuilder.ComputerExample;

public abstract class BuilderAbstract
{
    protected Computer Computer = new();
    public Computer Build()
    {
        return Computer;
    }
}