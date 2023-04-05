using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecomm.Models
{
    public class BookAuthor
    {
        [Key]
        public int AuthorId { get; set; }
        //[Required]
        public string AuthorName { get; set; }
        //[Required]
        public string Gender { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public ICollection<Book> Books { get; set; }
        public ICollection<BookCover> BookCovers { get; set; }
    }

    

}
