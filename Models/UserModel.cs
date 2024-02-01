using System.ComponentModel.DataAnnotations;

namespace BooksApp.Models
{

    public class UserModel
    {

        //Properties

        public int Id { get; set; }
        
        [Display(Name = "Låntagare")]
        public string? Name { get; set; }

        public List<BookModel>? Books { get; set; }
    }
}