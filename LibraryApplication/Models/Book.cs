
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApplication.Models
{
    [Table("Book")]
    public class Book
    {

        [Key]
        public int Bookid { get; set; }
        [Required]
        public string? Bookname { get; set; }
        [Required]

       
        public string? Author { get; set; }
        [Required]
        public int Price { get; set; }

    }
}
