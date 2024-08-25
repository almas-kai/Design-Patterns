class MethodHandler : HandlerAbstract
{
    public override void HandleRequest(Request request)
    {
        Console.WriteLine("The request is being handled by the MethodHandler.");
        if (request.Method == "GET")
        {
            Console.WriteLine("The request was successully handled. Returning the results.");
            return;
        }
        else if (request.Method == "POST")
        {
            if (request.Data is not null)
            {
                Console.WriteLine($"The request was successfully handled. Posting the data: {request.Data}.");
                return;
            }
            else
            {
                Console.WriteLine($"Cannot post the data that doesn't exist.");
                return;
            }
        }
        Console.WriteLine("The Method is invalid.");
    }
}