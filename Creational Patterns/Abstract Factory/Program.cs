namespace Abstract_Factory;

class Program
{
    static void Main(string[] args)
    {
        AbstractPhoneFactory phoneFactory = MainFactory.GetAndroidFactory();
        phoneFactory.GetProcessor().Embed();
        phoneFactory.GetScreen().Create();

        phoneFactory = MainFactory.GetAppleFactory();
        phoneFactory.GetProcessor().Embed();
        phoneFactory.GetScreen().Create();
    }
}
