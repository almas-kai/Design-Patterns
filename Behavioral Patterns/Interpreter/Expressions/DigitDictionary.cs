static class DigitDictionary
{
	private static Dictionary<char, sbyte> _FromCharToByte = new Dictionary<char, sbyte>()
	{
		{ '0', 0 }, { '1', 1 }, { '2', 2 }, { '3', 3 }, { '4', 4 }, { '5', 5 }, { '6', 6 }, { '7', 7 }, { '8', 8 }, { '9', 9 }
	};
	public static sbyte GetDigitFromChar(char digit)
	{
		if (!_FromCharToByte.ContainsKey(digit))
		{
			throw new ArgumentException("The provided argument wasn't digit.", nameof(digit));
		}
		return _FromCharToByte[digit];
	}
}