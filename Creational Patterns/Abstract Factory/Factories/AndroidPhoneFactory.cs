using Abstract_Factory.Products;

namespace Abstract_Factory;

public class AndroidPhoneFactory : AbstractPhoneFactory
{
    public override IProcessor GetProcessor()
    {
        return new ExynossCPU();
    }

    public override IScreen GetScreen()
    {
        return new Amoled();
    }
}