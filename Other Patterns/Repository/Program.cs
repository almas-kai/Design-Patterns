namespace Repository;

class Program
{
	static void Main(string[] args)
	{
		IRepository<int> repositoryOfInts = new InMemoryRepository<int>();
		repositoryOfInts.Add(100);
		repositoryOfInts.Add(99);

		Console.WriteLine(string.Join(", ", repositoryOfInts.GetAll()));

		repositoryOfInts.Remove(99);
		Console.WriteLine(string.Join(", ", repositoryOfInts.GetAll()));
	}
}
