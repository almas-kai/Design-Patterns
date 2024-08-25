namespace Chain_Of_Responsibility;

class Program
{
    static void Main()
    {
        HandlerAbstract rootHandler = GetRootHandler();
        Request[] requests = GetRequests();

        HandleEachRequest(requests, rootHandler);
    }
    private static HandlerAbstract GetRootHandler()
    {
        AuthenticationHandler authenticationHandler = new AuthenticationHandler();
        PathHandler pathHandler = new PathHandler();
        MethodHandler methodHandler = new MethodHandler();

        authenticationHandler.SetNextHandler(pathHandler);
        pathHandler.SetNextHandler(methodHandler);

        return authenticationHandler;
    }
    private static Request[] GetRequests()
    {
        return new Request[]{
            new Request("Admin", "/", "GET"),
            new Request("Admin", "/history", "POST", "New Order. Order ID: 2002")
        };
    }
    private static void HandleEachRequest(Request[] requests, HandlerAbstract rootHandler)
    {
        foreach (Request request in requests)
        {
            rootHandler.HandleRequest(request);
            Console.WriteLine();
        }
    }
}
