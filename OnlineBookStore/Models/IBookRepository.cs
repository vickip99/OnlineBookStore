namespace OnlineBookStore.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }

    }
}
