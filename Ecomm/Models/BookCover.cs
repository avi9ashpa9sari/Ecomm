using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecomm.Models
{
    public class BookCover
    {
        [Key]
        public int CoverId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public int BookAuthorId { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public ICollection<Book> Books { get; set; }
        //public BookAuthor AuthorId { get; set; } 
    }
}
