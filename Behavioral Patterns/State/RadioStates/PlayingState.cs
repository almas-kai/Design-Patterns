class PlayingState : RadioStateAbstract
{
    public PlayingState(RadioContext radioContext) : base(radioContext) { }
    public override void PlayRadio()
    {
        Console.WriteLine("The radio is already playing some music.");
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