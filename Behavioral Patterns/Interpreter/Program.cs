namespace Interpreter;

class Program
{
    static void Main()
    {
        BigNumberExpression num1 = new BigNumberExpression("777");
        BigNumberExpression num2 = new BigNumberExpression("2");

        AddBigPositiveNumbersExpression addition = new AddBigPositiveNumbersExpression(num1, num2);

        addition.Interpret();
    }
}
