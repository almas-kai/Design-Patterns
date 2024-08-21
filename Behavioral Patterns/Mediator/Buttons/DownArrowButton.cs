class DownArrowButton : ButtonAbstract
{
    public DownArrowButton(IMediator mediator) : base(mediator) { }
    public override void Press()
    {
        _Mediator.Notify("DownArrow");
    }
}