class AuthenticationHandler : HandlerAbstract
{
    public override void HandleRequest(Request request)
    {
        Console.WriteLine("The request is being handled by the AuthenticationHandler.");
        if (request.AuthenticationMode == "Admin")
        {
            Console.WriteLine("AuthenticationMode is valid.");
            if (_NextHandler is not null)
            {
                _NextHandler.HandleRequest(request);
                return;
            }
            Console.WriteLine("Unfortunately there doesn't exist the next handler.");
            return;
        }
        Console.WriteLine("The request is not acceptable.");
    }
}