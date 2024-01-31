using System.ComponentModel.DataAnnotations;

namespace BooksApp.Models
{

    public class AuthorModel
    {

        //Properties

        public int Id { get; set; }
        [Display(Name = "Namn")]
        public string? Name { get; set; }

        public List<BookModel>? Books { get; set; }
    }
}