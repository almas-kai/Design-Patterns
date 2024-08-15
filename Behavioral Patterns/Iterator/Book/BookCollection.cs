public class BookCollection : IBookCollection
{
    private List<Book> _books = new List<Book>();

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public IIterator<Book> CreateIterator()
    {
        return new BookIterator(this);
    }

    public int Count => _books.Count;

    public Book this[int index]
    {
        get { return _books[index]; }
    }
}
