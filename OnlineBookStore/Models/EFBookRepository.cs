
namespace OnlineBookStore.Models
{
    public class EFBookRepository : IBookRepository
    {
        private OnlineBookStoreContext _context;
        public EFBookRepository(OnlineBookStoreContext temp) 
        {
            _context = temp;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
