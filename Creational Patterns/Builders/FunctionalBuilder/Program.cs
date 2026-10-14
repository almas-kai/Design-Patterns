using FunctionalBuilder.Builders;
using FunctionalBuilder.ProductToBuild;

namespace FunctionalBuilder;

class Program
{
    static void Main()
    {
        Person person = new PersonBuilder()
            .Called("John Doe")
            .YearsOld(30)
            .WorksAs("AI Engineer")
            .Build();

        Console.WriteLine(person);
    }
}
