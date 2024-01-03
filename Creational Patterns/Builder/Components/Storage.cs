namespace Builder;

public class Storage : IComponent
{
    public string Name { get; set; } = "Simple Storage";
    public Dictionary<string, string> Characteristics { get; set; } = new Dictionary<string, string>();
}