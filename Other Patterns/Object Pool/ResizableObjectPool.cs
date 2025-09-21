namespace Object_Pool;

public class ResizableObjectPool<T> where T : class
{
	private readonly Func<T> _factory;
	private const int MIN_SIZE = 8;
	private readonly List<PoolItem> _pool;
	private readonly Action<T>? _onRelease;
	public int PoolSize => _pool.Count;
	public ResizableObjectPool(Func<T> factory, int initialSize = 8, bool isLazyInitializationOn = true, Action<T>? onRelease = null)
	{
		initialSize = initialSize > MIN_SIZE ? initialSize : MIN_SIZE;

		_factory = factory;

		_onRelease = onRelease;

		_pool = new List<PoolItem>(initialSize);

		if (isLazyInitializationOn is false)
		{
			for (int i = 0; i < initialSize; i++)
			{
				_pool.Add(new PoolItem(_factory(), false));
			}
		}
	}
	public T RequestItem()
	{
		PoolItem? freeItem = _pool.Where((item) => item.IsBusy == false)
			.FirstOrDefault();

		if (freeItem is null)
		{
			freeItem = new PoolItem(_factory(), true);
			_pool.Add(freeItem);
		}
		else
		{
			freeItem.IsBusy = true;
		}

		return freeItem.Item;
	}
	public void ReleaseItem(T item)
	{
		PoolItem? busyItem = _pool.Where((poolItem) => poolItem.Item == item)
			.FirstOrDefault();

		if (busyItem is null)
		{
			throw new InvalidOperationException("The item doesn't belong to the pool.");
		}

		busyItem.IsBusy = false;

		if (_onRelease is not null)
		{
			_onRelease(busyItem.Item);
		}
	}
	private class PoolItem
	{
		public bool IsBusy;
		public T Item;
		public PoolItem(T item, bool isBusy = false)
		{
			IsBusy = isBusy;
			Item = item;
		}
	}
}