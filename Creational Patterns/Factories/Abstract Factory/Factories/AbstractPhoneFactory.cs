using Abstract_Factory.Products;

namespace Abstract_Factory;

public abstract class AbstractPhoneFactory {
    public abstract IScreen GetScreen();
    public abstract IProcessor GetProcessor();
}