namespace Arghiroiu_Raluca_Lab2.Models
{
    public class BookCategory
    {
        public int ID { get; set; }

        public int BookID { get; set; }
        public Book Book { get; set; } // reference navigation property

        public int CategoryID { get; set; }
        public Category Category { get; set; } // reference navigation property
    }
}
