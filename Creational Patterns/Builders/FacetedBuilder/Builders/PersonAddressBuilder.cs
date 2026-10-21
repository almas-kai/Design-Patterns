using FacetedBuilder.ProductToBuild;

namespace FacetedBuilder.Builders;

internal sealed class PersonAddressBuilder : FacetedPersonBuilder
{
    public PersonAddressBuilder(Person person)
    {
        Person = person;
    }
    public PersonAddressBuilder SetCity(string city)
    {
        Person.City = city;
        return this;
    }

    public PersonAddressBuilder SetHome(string home)
    {
        Person.Home = home;
        return this;
    }

    public PersonAddressBuilder SetApartment(string apartment)
    {
        Person.Apartment = apartment;
        return this;
    }
}