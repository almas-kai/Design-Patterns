internal static class NumbersFilter
{
	public static List<int> Filter(List<int> ints, ISpecification<int> specification)
	{
		List<int> result = new List<int>();

		foreach (int i in ints)
		{
			if (specification.IsSatisfiedBy(i))
			{
				result.Add(i);
			}
		}

		return result;
	}
}