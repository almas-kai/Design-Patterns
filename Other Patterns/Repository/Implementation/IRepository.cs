internal interface IRepository<T>
{
  public IEnumerable<T> GetAll();
  public T? Find(Predicate<T> predicate);
  public void Remove(T item);
  public void Add(T item);
}