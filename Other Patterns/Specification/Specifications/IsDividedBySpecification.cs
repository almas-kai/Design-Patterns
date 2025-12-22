internal class IsDividedBySpecification : ISpecification<int>
{
	private int _numberToBeDividedBy;

	public IsDividedBySpecification(int number)
	{
		this._numberToBeDividedBy = number;
	}

	public bool IsSatisfiedBy(int entity)
	{
		return entity % this._numberToBeDividedBy == 0;
	}
}