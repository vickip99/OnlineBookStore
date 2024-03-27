namespace OnlineBookStore.Models
{
    public interface IBookRepository
    {
        // Property to access the collection of books
        public IQueryable<Book> Books { get; }

    }
}
