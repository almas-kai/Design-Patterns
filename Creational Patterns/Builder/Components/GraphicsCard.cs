namespace Builder;

public class GraphicsCard : IComponent
{
    public string Name { get; set; } = "Simple Graphics Card";
    public Dictionary<string, string> Characteristics { get; set; } = new Dictionary<string, string>();
}