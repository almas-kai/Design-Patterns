namespace Adapter;

public class AutoPart
{
	public string Name { get; set; }
	public int Amount { get; set; }
	public decimal Price { get; set; }
	public AutoPart(string name, int amount, decimal price)
	{
		Name = name;
		Amount = amount;
		Price = price;
	}
    public override string ToString()
    {
		return $"{Name} {Amount} {Price}";
    }
}