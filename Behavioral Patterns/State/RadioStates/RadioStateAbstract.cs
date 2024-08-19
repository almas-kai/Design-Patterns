abstract class RadioStateAbstract
{
    private protected RadioContext _RadioContext { get; set; }
    public RadioStateAbstract(RadioContext radioContext)
    {
        _RadioContext = radioContext;
    }
    public abstract void TurnOff();
    public abstract void TurnOn();
    public abstract void PlayRadio();
}