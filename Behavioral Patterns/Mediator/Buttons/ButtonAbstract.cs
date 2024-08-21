abstract class ButtonAbstract
{
    private protected IMediator _Mediator { get; set; }
    public ButtonAbstract(IMediator mediator)
    {
        _Mediator = mediator;
    }
    public abstract void Press();
}