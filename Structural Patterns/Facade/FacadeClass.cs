namespace Facade;

public static class FacadeClass {
	private static Internet Internet = new Internet();
	private static ISP ISP = new ISP();
	private static Cable Cable = new Cable();
	private static Router Router = new Router();
	public static void MakeRequest(string title){
		Console.WriteLine("\nMaking a request through the Facade!");
		ISP.ConnectToTheInternet();
		Router.MakeRequest(title);
		Cable.PassDataFurther(Router.Title);
		Internet.FulfillRequest(Router.Title);
	}
}