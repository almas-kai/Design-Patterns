class NoDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal price)
    {
        return price;
    }
}