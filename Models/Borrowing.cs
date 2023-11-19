using System.ComponentModel.DataAnnotations;

namespace Arghiroiu_Raluca_Lab2.Models
{
    public class Borrowing
    {
        public int ID { get; set; }

        public int? MemberID { get; set; }
        public Member? Member { get; set; } // reference navigation property

        public int? BookID { get; set; }
        public Book? Book { get; set; } // reference navigation property

        [Display(Name = "Return Date")]
        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }
    }
}
