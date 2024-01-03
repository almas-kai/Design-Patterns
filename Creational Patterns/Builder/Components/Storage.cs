namespace Builder;

public class Storage : IComponent
{
    public string Name { get; set; }
    public Dictionary<string, string> Characteristics { get; set; } = new Dictionary<string, string>();
}