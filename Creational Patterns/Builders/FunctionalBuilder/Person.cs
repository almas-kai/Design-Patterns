namespace FunctionalBuilder.ProductToBuild;

public sealed class Person
{
    public string Name { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public byte Age { get; set; }

    public override string ToString()
    {
        return $@"
            My name is {Name}. I am {Age} years old. My position is {Position}.
        ";
    }
}