using FacetedBuilder.ProductToBuild;

namespace FacetedBuilder.Builders;

internal sealed class PersonIdentityBuilder : FacetedPersonBuilder
{
    public PersonIdentityBuilder(Person person)
    {
        Person = person;
    }
    public PersonIdentityBuilder SetName(string name)
    {
        Person.Name = name;
        return this;
    }

    public PersonIdentityBuilder SetLastName(string lastName)
    {
        Person.LastName = lastName;
        return this;
    }

    public PersonIdentityBuilder SetAge(byte age)
    {
        Person.Age = age;
        return this;
    }
}