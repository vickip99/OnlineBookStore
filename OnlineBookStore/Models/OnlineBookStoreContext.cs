using Microsoft.EntityFrameworkCore;

namespace OnlineBookStore.Models
{
    public class OnlineBookStoreContext : DbContext
    {
        public OnlineBookStoreContext (DbContextOptions<OnlineBookStoreContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
    }
}
