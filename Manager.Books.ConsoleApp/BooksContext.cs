using Microsoft.EntityFrameworkCore;

namespace Manager.Books.ConsoleApp
{
    public class BooksContext : DbContext
    {
        public DbSet<Books> Books {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=booksDB.db");
        }
    }
}