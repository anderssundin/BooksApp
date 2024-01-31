using System.ComponentModel.DataAnnotations;
namespace BooksApp.Models
{

    public class BookModel
    {
        //Properties

        public int Id { get; set; }
        [Display(Name = "Titel")]
        public string? Title { get; set; }
        [Display(Name = "Utgivningsår")]
        public int? ReleaseYear { get; set; }
        [Display(Name = "Sidor")]
        public int? Pages { get; set; }
        [Display(Name = "Tillgänglig")]
        public bool Available { get; set; } = true;
        [Display(Name = "Författare")]
        public int? AuthorId { get; set; }
        [Display(Name = "Författare")]
        public AuthorModel? Author { get; set; }


    }
}