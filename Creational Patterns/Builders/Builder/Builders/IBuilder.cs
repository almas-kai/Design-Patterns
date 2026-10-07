namespace Builder;

public interface IBuilder{
    public IBuilder SetCPU();
    public IBuilder SetGraphicsCard();
    public IBuilder SetMemory();
    public IBuilder SetStorage();
    public Computer GetProduct();
}