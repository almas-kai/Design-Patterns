class FixedAmountDiscount : IDiscountStrategy
{
    private readonly decimal _fixedAmount;
    public FixedAmountDiscount(decimal fixedAmount)
    {
        _fixedAmount = fixedAmount;
    }
    public decimal ApplyDiscount(decimal price)
    {
        return price - _fixedAmount;
    }
}