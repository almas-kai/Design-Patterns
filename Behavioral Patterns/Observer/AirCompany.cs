class AirCompany
{
	private List<IObserver> Observers = new List<IObserver>();
	public string Name { get; private set; }
	public AirCompany(string name)
	{
		Name = name;
	}
	public void DelayFlight(DateTime dateTime)
	{
		_NotifyObservers($"Sorry the flight was delayed. Your flight will be at {dateTime}.");
	}
	public void Register(IObserver observer)
	{
		Observers.Add(observer);
	}
	public void UnRegister(IObserver observer)
	{
		Observers.Remove(observer);
	}
	private void _NotifyObservers(string message)
	{
		foreach (IObserver observer in Observers)
		{
			observer.Update(this, message);
		}
	}
}