
namespace Adapter;

// Object adapter.
public class Adapter : IProductImporter
{
	private readonly IThirdPartyProductImporter _thirdPartyProductImporter;
	public Adapter(IThirdPartyProductImporter thirdPartyProductImporter){
		_thirdPartyProductImporter = thirdPartyProductImporter;
	}
    public List<AutoPart> GetAutoParts()
    {
		return _thirdPartyProductImporter.ImportParts();
    }
}