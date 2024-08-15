public interface IIterator<T>
{
    T Current { get; }
    bool MoveNext();
    void Reset();
}
