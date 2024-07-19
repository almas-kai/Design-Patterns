
namespace Adapter;

// Our system.
public class ProductImporter : IProductImporter
{
	public List<AutoPart> GetAutoParts()
	{
		return new List<AutoPart>(){
			new AutoPart("Engine", 10, 10000.00m),
			new AutoPart("Windshield", 5, 100.00m)
		};
	}
}