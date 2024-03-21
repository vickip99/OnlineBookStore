
namespace OnlineBookStore.Models
{
    public class EFBookRepository : IBookRepository
    {
        private OnlineBookStoreContext _context;

        //initialize the repository with a database context
        public EFBookRepository(OnlineBookStoreContext temp) 
        {
            _context = temp;
        }
        //provides access to the collection/set of books in the DB
        public IQueryable<Book> Books => _context.Books;
    }
}
