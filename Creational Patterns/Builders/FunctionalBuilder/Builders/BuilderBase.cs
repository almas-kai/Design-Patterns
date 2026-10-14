namespace FunctionalBuilder.Builders;

public abstract class BuilderBase<TProductToBuild, TSelf>
    where TProductToBuild : class, new()
    where TSelf : BuilderBase<TProductToBuild, TSelf>
{
    protected BuilderBase()
    {
        if(this is not TSelf)
        {
            throw new InvalidOperationException($"{GetType()} must close BuilderBase as itself (TSelf = {typeof(TSelf)}).");
        }
    }
    private readonly List<Func<TProductToBuild, TProductToBuild>> _actions = new();
    public TProductToBuild Build()
        => _actions.Aggregate(new TProductToBuild(), (productToBuild, action) => action(productToBuild));

    public TSelf AddAction(Action<TProductToBuild> action)
    {
        _actions.Add((productToBuild) =>
        {
            action(productToBuild);
            return productToBuild;
        });
        return (TSelf)this;
    }
}