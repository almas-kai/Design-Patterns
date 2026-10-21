namespace FacetedBuilder.ProductToBuild;

internal sealed class Person
{
    public string Name { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public byte Age { get; set; }
    public string City { get; set; } = string.Empty;
    public string Home { get; set; } = string.Empty;
    public string Apartment { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"""
            Name: {Name},
            LastName: {LastName},
            Age: {Age},
            City: {City},
            Home: {Home},
            Apartment: {Apartment}.
        """;
    }
}