namespace Strategy;

class Program
{
    static void Main()
    {
        decimal totalPrice = 1000m;

        ShoppingCart shoppingCart = new ShoppingCart();

        Console.WriteLine($"Total price with no discount: {shoppingCart.CalculateTotalPrice(totalPrice)}.");

        shoppingCart.SetDiscountStrategy(new PercentageDiscount(50));
        Console.WriteLine($"Total price with 50% discount: {shoppingCart.CalculateTotalPrice(totalPrice)}.");

        shoppingCart.SetDiscountStrategy(new FixedAmountDiscount(100));
        Console.WriteLine($"Total price with 100$ bonus discount: {shoppingCart.CalculateTotalPrice(totalPrice)}.");
    }
}
