class ShoppingCart
{
    private IDiscountStrategy _DiscountStrategy = new NoDiscount();
    public ShoppingCart() { }
    public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
    {
        _DiscountStrategy = discountStrategy;
    }
    public decimal CalculateTotalPrice(decimal price)
    {
        return _DiscountStrategy.ApplyDiscount(price);
    }
}