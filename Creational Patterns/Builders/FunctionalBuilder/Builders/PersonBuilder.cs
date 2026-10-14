using FunctionalBuilder.ProductToBuild;

namespace FunctionalBuilder.Builders;

public sealed class PersonBuilder
    : BuilderBase<Person, PersonBuilder>
{
    public PersonBuilder Called(string name)
        => AddAction((person) => person.Name = name);
    public PersonBuilder WorksAs(string position)
        => AddAction((person) => person.Position = position);
    public PersonBuilder YearsOld(byte age)
        => AddAction((person) => person.Age = age);
}