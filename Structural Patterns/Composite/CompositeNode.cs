namespace Composite;

class CompositeNode : IDataStorage
{
	public string Name { get; private set; }
	private int _Size;

	public int Size
	{
		get
		{
			int totalSize = _Size;
			foreach(IDataStorage dataStorage in _Children){
				totalSize += dataStorage.Size;
			}
			return totalSize;
		}
		private set
		{
			_Size = value;
		}
	}
	private List<IDataStorage> _Children = new List<IDataStorage>();
	public CompositeNode(string name)
	{
		Name = name;
		Size = 4; // Overhead.
	}

	public void Delete()
	{
		foreach (IDataStorage dataStorage in _Children)
		{
			dataStorage.Delete();
		}
		Console.WriteLine($"The folder named \"{Name}\" has been deleted successfully.");
	}
	public void AddChildNode(IDataStorage child)
	{
		_Children.Add(child);
	}
	public void RemoveChildNode(IDataStorage child)
	{
		_Children.Remove(child);
	}

    public void DisplayDescription()
    {
        Console.WriteLine($"Folder name: {Name}, folder size: {Size}, folder contents:");
		foreach(IDataStorage dataStorage in _Children){
			dataStorage.DisplayDescription();
		}
    }
}