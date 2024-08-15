public class BookIterator : IIterator<Book>
{
    private BookCollection _bookCollection;
    private int _currentIndex = -1;

    public BookIterator(BookCollection bookCollection)
    {
        _bookCollection = bookCollection;
    }

    public Book Current
    {
        get
        {
            if (_currentIndex < 0 || _currentIndex >= _bookCollection.Count)
                throw new InvalidOperationException();
            return _bookCollection[_currentIndex];
        }
    }

    public bool MoveNext()
    {
        if (_currentIndex < _bookCollection.Count - 1)
        {
            _currentIndex++;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        _currentIndex = -1;
    }
}
