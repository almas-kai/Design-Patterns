namespace Facade;

public class Router {
	public string Title { get; private set; }
	public void MakeRequest(string title){
		Title = title;
		Console.WriteLine($"Requesting {title}.");
	}
}