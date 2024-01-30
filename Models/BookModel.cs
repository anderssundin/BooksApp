namespace BooksApp.Models{

    public class BookModel {
        //Properties

        public int Id { get; set; }

        public string? Title { get; set; }  

        public int? ReleaseYear { get; set; }

        public int? Pages { get; set; }

        public bool Available { get; set; } = true;

        public int AuthorId { get; set; }   

        public int GenreId { get; set; }    
    }
}