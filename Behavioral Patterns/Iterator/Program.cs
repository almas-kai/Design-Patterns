namespace Iterator;

class Program
{
    static void Main(string[] args)
    {
        BookCollection books = new BookCollection();
        books.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
        books.AddBook(new Book("Moby Dick", "Herman Melville"));
        books.AddBook(new Book("1984", "George Orwell"));

        IIterator<Book> iterator = books.CreateIterator();

        while (iterator.MoveNext())
        {
            Book currentBook = iterator.Current;
            Console.WriteLine($"{currentBook.Title} by {currentBook.Author}");
        }
    }
}
