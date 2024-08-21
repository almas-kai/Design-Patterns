class UpArrowButton : ButtonAbstract
{
    public UpArrowButton(IMediator mediator) : base(mediator) { }
    public override void Press()
    {
        _Mediator.Notify("UpArrow");
    }
}