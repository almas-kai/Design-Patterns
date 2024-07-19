
namespace Adapter;

public class ThirdPartyProductImporter : IThirdPartyProductImporter
{
	public List<AutoPart> ImportParts()
	{
		return new List<AutoPart>(){
			new AutoPart("Seats", 10, 50.00m),
			new AutoPart("Accumulator", 20, 35.00m)
		};
	}
}