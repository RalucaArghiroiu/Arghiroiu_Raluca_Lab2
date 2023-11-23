using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Arghiroiu_Raluca_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Title")]
        [Required(ErrorMessage = "Acest camp este obligatoriu!")]
        [StringLength(150, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Author")]
        public int? AuthorID { get; set; }

        public Author? Author { get; set; } // reference navigation property

        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Publishing Date")]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }

        public Publisher? Publisher { get; set; } // reference navigation property

        [Display(Name = "Book Categories")]
        public ICollection<BookCategory>? BookCategories { get; set; } // collection navigation property

        public ICollection<Borrowing>? Borrowings { get; set; } // collection navigation property
    }
}
