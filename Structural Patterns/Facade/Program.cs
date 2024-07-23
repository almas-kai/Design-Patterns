namespace Facade;

class Program
{
    static void Main()
    {
        // Without a facade we need to set-up the correct order of execution!
        ISP isp = new ISP();
        isp.ConnectToTheInternet();
        Router router = new Router();
        router.MakeRequest("Find funny cat videos");
        Cable cable = new Cable();
        cable.PassDataFurther(router.Title);
        Internet internet = new Internet();
        internet.FulfillRequest(router.Title);

        // With Facade!
        FacadeClass.MakeRequest("Find funny cat videos");
    }
}
