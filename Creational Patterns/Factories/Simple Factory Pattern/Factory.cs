static class Factory
{
    // Better use different methods (e.g. GetPhoneProduct, GetComputerProduct and so on).
    public static IProduct GetProduct(string productType)
    {
        switch (productType)
        {
            case "phone":
                return new Phone();
            case "computer":
                return new Computer();
            default:
                throw new ArgumentException("Unknown product type", nameof(productType));
        }
    }
}