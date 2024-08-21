class RightArrowButton : ButtonAbstract
{
    public RightArrowButton(IMediator mediator) : base(mediator) { }
    public override void Press()
    {
        _Mediator.Notify("RightArrow");
    }
}