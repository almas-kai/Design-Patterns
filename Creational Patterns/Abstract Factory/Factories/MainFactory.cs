using Abstract_Factory.Products;

namespace Abstract_Factory;

public static class MainFactory {
    public static AbstractPhoneFactory GetAppleFactory(){
        return new ApplePhoneFactory();
    }
    public static AbstractPhoneFactory GetAndroidFactory(){
        return new AndroidPhoneFactory();
    }
}