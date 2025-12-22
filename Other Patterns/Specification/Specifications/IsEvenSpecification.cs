internal class IsEvenSpecification : ISpecification<int>
{
	public bool IsSatisfiedBy(int entity)
	{
		return entity % 2 == 0;
	}
}