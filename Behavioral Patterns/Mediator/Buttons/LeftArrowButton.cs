class LeftArrowButton : ButtonAbstract
{
    public LeftArrowButton(IMediator mediator) : base(mediator) { }
    public override void Press()
    {
        _Mediator.Notify("LeftArrow");
    }
}