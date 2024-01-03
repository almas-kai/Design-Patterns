namespace Builder;

public interface IComponent{
    public string Name { get; set;}
    public Dictionary<string, string> Characteristics { get; set; }
}