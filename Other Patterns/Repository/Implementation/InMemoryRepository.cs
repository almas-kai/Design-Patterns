
internal class InMemoryRepository<T> : IRepository<T>
{
	private List<T> _values = new List<T>();

	public void Add(T item)
	{
		this._values.Add(item);
	}

	public T? Find(Predicate<T> predicate)
	{
		return this._values.Find(predicate);
	}

	public IEnumerable<T> GetAll()
	{
		return this._values.AsReadOnly();
	}

	public void Remove(T item)
	{
		this._values.Remove(item);
	}
}