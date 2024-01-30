using BooksApp.Models;
using Microsoft.EntityFrameworkCore;
namespace BooksApp.Data
{

    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }

        // Tabels to database
        public DbSet<BookModel> Book { get; set; }

        public DbSet<AuthorModel> Author { get; set; }

        public DbSet<GenreModel> Genre { get; set; }

        public DbSet<LoanModel> Loan { get; set; }
    }

}