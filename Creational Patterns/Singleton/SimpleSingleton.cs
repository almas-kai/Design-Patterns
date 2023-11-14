namespace Singleton;

///<summary>
///  The simplest version of singleton, should be used in single-threaded environment.
///</summary>
public sealed class SimpleSingleton{
    /* 
        Static initialization method of getting only one instance (as you know static members of a class initialized only once). It is initialized eagerly.
    */
    private static readonly SimpleSingleton _onlyInstance = new SimpleSingleton();
    public Guid Uniqueness { get; private set; } = Guid.NewGuid();

    private SimpleSingleton(){}

    public static SimpleSingleton GetSimpleSingleton{
        get{
            return _onlyInstance;
        }
    }
}