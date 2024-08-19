class TurnedOnState : RadioStateAbstract
{
    public TurnedOnState(RadioContext radioContext) : base(radioContext) { }
    public override void PlayRadio()
    {
        Console.WriteLine("Playing some music.");
        _RadioContext.TransitionTo(new PlayingState(_RadioContext));
    }

    public override void TurnOff()
    {
        Console.WriteLine("Turning off the radio.");
        _RadioContext.TransitionTo(new TurnedOffState(_RadioContext));
    }

    public override void TurnOn()
    {
        Console.WriteLine("The radio is already turned on.");
    }
}