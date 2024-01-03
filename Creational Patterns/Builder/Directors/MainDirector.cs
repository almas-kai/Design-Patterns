namespace Builder;

public class MainDirector{
    private IBuilder _builder;
    public MainDirector(IBuilder builder){
        _builder = builder;
    }
    public Computer Build(){
        return _builder.SetCPU().SetGraphicsCard().SetMemory().SetStorage().GetProduct();
    }
}