namespace Double_Buffer;

public class DoubleBuffer<T>
{
	private readonly T[] _buffers = new T[2];
	private int _front = 0;
	private readonly object _swapLock = new object();
	public DoubleBuffer(Func<T> initializer)
	{
		_buffers[0] = initializer();
		_buffers[1] = initializer();
	}

	public T Front
	{
		get
		{
			lock (_swapLock)
			{
				return _buffers[_front];
			}
		}
	}

	public T Back
	{
		get
		{
			lock (_swapLock)
			{
				return _buffers[1 - _front];
			}
		}
	}

	public void Swap()
	{
		lock (_swapLock)
		{
			_front = 1 - _front;
		}
	}
}