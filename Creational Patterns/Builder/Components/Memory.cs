namespace Builder;

public class Memory : IComponent
{
    public string Name { get; set; } = "Simple Memory";
    public Dictionary<string, string> Characteristics { get; set; } = new Dictionary<string, string>();
}