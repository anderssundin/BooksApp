using System.ComponentModel.DataAnnotations;

namespace BooksApp.Models
{

    public class UserModel
    {

        //Properties

        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Låntagare")]
        public string? Name { get; set; }

        public List<BookModel>? Books { get; set; }
    }
}