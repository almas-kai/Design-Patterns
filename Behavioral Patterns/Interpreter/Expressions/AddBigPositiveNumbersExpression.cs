using System.Text;

class AddBigPositiveNumbersExpression : IExpression
{
	public IExpression Left { get; private set; }
	public IExpression Right { get; private set; }
	public AddBigPositiveNumbersExpression(IExpression left, IExpression right)
	{
		Left = left;
		Right = right;
	}
	public string Interpret()
	{
		Console.WriteLine($"Returning the addition of the {Left.Interpret()} and {Right.Interpret()}, which equals to {_Add(Left.Interpret(), Right.Interpret())}.");
		return _Add(Left.Interpret(), Right.Interpret());
	}
	private static string _Add(string left, string right)
	{
		StringBuilder result = new StringBuilder();
		sbyte a, b;
		int sum, remainder = 0;
		int leftIndex = left.Length - 1, rightIndex = right.Length - 1;

		while (leftIndex != -1 && rightIndex != -1)
		{
			a = DigitDictionary.GetDigitFromChar(left[leftIndex--]);
			b = DigitDictionary.GetDigitFromChar(right[rightIndex--]);

			sum = a + b + remainder;
			remainder = sum > 9 ? 1 : 0;

			result.Append(sum > 9 ? sum % 10 : sum);
		}

		if (leftIndex != -1)
		{
			_CalculateLeftovers(leftIndex, left, result);
		}
		else if (rightIndex != -1)
		{
			_CalculateLeftovers(rightIndex, right, result);
		}

		return new string(result.ToString().Reverse().ToArray());
	}
	private static void _CalculateLeftovers(int startIndex, string number, StringBuilder result){
		int num, sum, remainder = 0;
		while (startIndex != -1)
		{
			num = DigitDictionary.GetDigitFromChar(number[startIndex--]);

			sum = num + remainder;
			remainder = sum > 9 ? 1 : 0;

			result.Append(sum > 9 ? sum % 10 : sum);
		}
	}
}