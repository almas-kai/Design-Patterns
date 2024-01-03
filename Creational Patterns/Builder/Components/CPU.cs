namespace Builder;

public class CPU : IComponent
{
    public string Name {get; set;}
    public Dictionary<string, string> Characteristics { get; set;} = new Dictionary<string, string>();
}