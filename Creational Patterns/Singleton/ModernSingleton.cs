public sealed class ModernSingleton
{
	private static readonly Lazy<ModernSingleton> _instance = new Lazy<ModernSingleton>(() => new ModernSingleton());

	public Guid UniqueField { get; private set; }
	public static ModernSingleton Instance => _instance.Value;
	private ModernSingleton()
	{
		UniqueField = Guid.NewGuid();
	}
}
