class PercentageDiscount : IDiscountStrategy
{
    private readonly decimal _percentage;
    public PercentageDiscount(decimal percentage)
    {
        _percentage = percentage;
    }
    public decimal ApplyDiscount(decimal price)
    {
        return price - (price * _percentage / 100);
    }
}