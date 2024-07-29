namespace Composite;

interface IDataStorage {
	public string Name { get; }
	public int Size { get; }
	public void Delete();
	public void DisplayDescription();
}