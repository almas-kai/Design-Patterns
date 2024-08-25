abstract class HandlerAbstract
{
    private protected HandlerAbstract? _NextHandler;
    public void SetNextHandler(HandlerAbstract nextHandler)
    {
        _NextHandler = nextHandler;
    }
    public abstract void HandleRequest(Request request);
}