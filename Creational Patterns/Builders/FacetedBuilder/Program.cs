using FacetedBuilder.Builders;
using FacetedBuilder.ProductToBuild;

namespace FacetedBuilder;

class Program
{
    static void Main()
    {
        Person implicitlyCastedPerson = new FacetedPersonBuilder()
            .Address
                .SetCity("Random City")
                .SetHome("Random Home")
                .SetApartment("Random Apartment")
            .Identity
                .SetName("Almas")
                .SetLastName("Kai")
                .SetAge(24);

        Console.WriteLine(implicitlyCastedPerson);
    }
}
