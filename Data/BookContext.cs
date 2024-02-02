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
        public DbSet<BookModel> Books { get; set; }

        public DbSet<AuthorModel> Authors { get; set; }

        public DbSet<UserModel> Users {get; set;}

    }

}