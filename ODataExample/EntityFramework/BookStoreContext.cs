using Microsoft.EntityFrameworkCore;
using ODataExample.Entities;

namespace ODataExample.EntityFramework
{
    public class BookStoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Press> Presses { get; set; }

        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().OwnsOne(c => c.Location);
        }
    }
}