namespace Singleton;

///<summary>
///  The thread-safe singleton implementation.
///</summary>
public sealed class ThreadSafeSingleton{
    private static ThreadSafeSingleton _onlyInstance;
    private static readonly object _lock = new Object();
    private ThreadSafeSingleton(){}

    // This is where client code can access our only instance (so-called access point).
    public static ThreadSafeSingleton GetSingleton{
        get{
            // This first check makes sure to use "lock" infrastructure only when it is necessary.
            if(_onlyInstance is null){
                lock(_lock){
                    if(_onlyInstance is null){
                        // Instantiate when requested (lazy initialization).
                        _onlyInstance = new ThreadSafeSingleton();
                    }
                }
            }
            return _onlyInstance;
        }
    }
}