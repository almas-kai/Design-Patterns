using FacetedBuilder.ProductToBuild;

namespace FacetedBuilder.Builders;

internal class FacetedPersonBuilder
{
    // Has to be a ref type.
    protected Person Person = new();

    // One way to get the product, is by casting builder to the product.
    public static implicit operator Person(FacetedPersonBuilder facetedPersonBuilder)
    {
        return facetedPersonBuilder.Person;
    }

    // Another, more conventional way to get the product.
    public Person Build()
    {
        return Person;
    }

    public PersonIdentityBuilder Identity => new(Person);
    public PersonAddressBuilder Address => new(Person);
}