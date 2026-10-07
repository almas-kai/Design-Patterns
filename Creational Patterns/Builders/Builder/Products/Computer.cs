namespace Builder;

public class Computer{
    public string Name { get; private set; }
    private List<IComponent> _components = new List<IComponent>();
    public Computer(string name){
        Name = name;
    }
    public void AddComponent(IComponent component){
        _components.Add(component);
    }
    public void ListAllComponents(){
        Console.WriteLine("***   ***");
        Console.WriteLine("Computer Name: " + Name);
        foreach(var component in _components){
            Console.WriteLine("\tComponent Name: " + component.Name);
            foreach(var property in component.Characteristics){
                Console.WriteLine("\t\t" + property.Key + ": " + property.Value + ".");
            }
        }
        Console.WriteLine("***   ***");
    }
}