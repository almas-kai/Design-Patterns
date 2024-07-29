namespace Composite;

class File : IDataStorage
{
    public string Name { get; private set; }
	public int Size { get; private set; }
	public File(string name, int size){
		Name = name;
		Size = size;
	}

    public void Delete()
    {
        Console.WriteLine($"The file named \"{Name}\" has been deleted successfully.");
    }

    public void DisplayDescription()
    {
        Console.WriteLine($"File name: {Name}, file size: {Size}.");
    }
}