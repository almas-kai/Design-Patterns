namespace Builder;

public class SimpleComputerBuilder : IBuilder
{
    private Computer _product = new Computer("Simple Computer.");
    public IBuilder SetCPU()
    {
        CPU simpleCPU = new CPU();
        simpleCPU.Characteristics.Add("Core Number", "4 Cores");
        simpleCPU.Characteristics.Add("Architecture", "x86");

        _product.AddComponent(simpleCPU);

        return this;
    }

    public IBuilder SetGraphicsCard()
    {
        GraphicsCard graphicsCard = new GraphicsCard();
        graphicsCard.Characteristics.Add("VRAM", "2GB");

        _product.AddComponent(graphicsCard);

        return this;
    }

    public IBuilder SetMemory()
    {
        Memory memory = new Memory();
        memory.Characteristics.Add("Size", "4GB");

        _product.AddComponent(memory);

        return this;
    }

    public IBuilder SetStorage()
    {
        Storage storage = new Storage();
        storage.Characteristics.Add("Size", "512GB");
        storage.Characteristics.Add("Type", "HDD");
        storage.Characteristics.Add("Speed", "7200RPM");

        _product.AddComponent(storage);

        return this;
    }

    public Computer GetProduct(){
        return _product;
    }
}