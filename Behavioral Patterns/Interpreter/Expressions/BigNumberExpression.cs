class BigNumberExpression : IExpression
{
	public string NumberValue { get; private set; }
	public BigNumberExpression(string number){
		NumberValue = number;
	}
	public string Interpret()
	{
		return NumberValue;
	}
}