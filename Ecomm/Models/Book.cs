using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecomm.Models
{
    public class Book
    {
        
        public int BookId { get; set; } 
        public string BookTitle { get; set; }
        public string BookDescription { get; set; }
        public double BookPrice { get; set; }
        public string ImageUrl { get; set; }
        public string BookUrl { get; set; }
        public DateTime BookDate { get; set; }
        public string ISBN { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [NotMapped]
        public IFormFile BookFile { get; set; }
        public int BookCoverId { get; set; }
        //public BookCover BookCover { get; set; }

        public int BookAuthorId { get; set; }
        //public BookAuthor BookAuthor { get; set; }
        
        
        
    }
}
