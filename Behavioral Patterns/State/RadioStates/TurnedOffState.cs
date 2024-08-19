class TurnedOffState : RadioStateAbstract
{
    public TurnedOffState(RadioContext radioContext) : base(radioContext) { }
    public override void PlayRadio()
    {
        Console.WriteLine("The radio is turned off. It is not possible to play some music.");
    }

    public override void TurnOff()
    {
        Console.WriteLine("The radio is already turned off.");
    }

    public override void TurnOn()
    {
        Console.WriteLine("Turning on the radio!");
        _RadioContext.TransitionTo(new TurnedOnState(_RadioContext));
    }
}