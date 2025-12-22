namespace Specification;

class Program
{
	static void Main(string[] args)
	{
		List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

		Console.WriteLine($"Before filter: {string.Join(", ", numbers)}.");

		ISpecification<int> evenSpecification = new IsEvenSpecification();
		ISpecification<int> dividedBy5Specification = new IsDividedBySpecification(5);

		ISpecification<int> andSpecification = new AndSpecification<int>(evenSpecification, dividedBy5Specification);

		numbers = NumbersFilter.Filter(numbers, andSpecification);

		Console.WriteLine($"After filter: {string.Join(", ", numbers)}.");
    }
}
