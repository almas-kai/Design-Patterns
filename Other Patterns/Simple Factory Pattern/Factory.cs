static class Factory
{
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