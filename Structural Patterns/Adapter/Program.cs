namespace Adapter;

class Program
{
    static void Main(string[] args)
    {
        IProductImporter productImporter = new ProductImporter();
        foreach(var v in productImporter.GetAutoParts()){
            Console.WriteLine(v);
        }

        IThirdPartyProductImporter thirdPartyProductImporter = new ThirdPartyProductImporter();
        IProductImporter productImporter2 = new Adapter(thirdPartyProductImporter);
        foreach(var f in productImporter2.GetAutoParts()){
            Console.WriteLine(f);
        }
    }
}
