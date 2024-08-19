class RadioContext
{
    private RadioStateAbstract _CurrentState { get; set; }
    public RadioContext()
    {
        _CurrentState = new TurnedOffState(this);
    }
    public void TransitionTo(RadioStateAbstract newState)
    {
        _CurrentState = newState;
    }
    public void TurnOn()
    {
        _CurrentState.TurnOn();
    }
    public void TurnOff()
    {
        _CurrentState.TurnOff();
    }
    public void PlayMusic()
    {
        _CurrentState.PlayRadio();
    }
}