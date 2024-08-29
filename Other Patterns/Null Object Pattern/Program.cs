namespace Null_Object_Pattern;

class Program
{
    static List<IProduct> GetProducts()
    {
        return new List<IProduct>()
        {
            new PhoneProduct(),
            new CarProduct(),
            new PhoneProduct(),
            new NullProduct()
        };
    }
    static void Main()
    {
        var products = GetProducts();

        foreach (IProduct product in products)
        {
            product.AboutMe();
        }
    }
}
