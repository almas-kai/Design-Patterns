using Abstract_Factory.Products;

namespace Abstract_Factory;

public class ApplePhoneFactory : AbstractPhoneFactory
{
    public override IProcessor GetProcessor()
    {
        return new AppleMCPU();
    }

    public override IScreen GetScreen()
    {
        return new IPS();
    }
}