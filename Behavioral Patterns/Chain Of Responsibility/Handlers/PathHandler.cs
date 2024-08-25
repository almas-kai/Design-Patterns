class PathHandler : HandlerAbstract
{
    private string[] _ValidPaths = new string[]{
        "/", "/history", "/settings"
    };
    public override void HandleRequest(Request request)
    {
        Console.WriteLine("The request is being handled by the PathHandler.");
        if (_ValidPaths.Contains(request.Path))
        {
            Console.WriteLine("This is a valid path!");
            if (_NextHandler is not null)
            {
                _NextHandler.HandleRequest(request);
                return;
            }
            Console.WriteLine("Unfortunately there doesn't exist the next handler.");
            return;
        }
        Console.WriteLine("The asked path is not valid.");
    }
}