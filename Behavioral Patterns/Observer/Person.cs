class Person : IObserver
{
	public string Name { get; private set; }
	public Person(string name)
	{
		Name = name;
	}
	public void Update(AirCompany airCompany, string message)
	{
		Console.WriteLine($"Hello {Name}!");
		Console.WriteLine($"Message from the {airCompany.Name}:");
		Console.WriteLine(message);
	}
}