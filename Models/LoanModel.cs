namespace BooksApp.Models
{

    public class LoanModel
    {

        //Properties

        public int Id { get; set; }

        public string? Name { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public int BookId { get; set; }
    }
}