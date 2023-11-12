using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Arghiroiu_Raluca_Lab2.Data;
using Arghiroiu_Raluca_Lab2.Models;

namespace Arghiroiu_Raluca_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Arghiroiu_Raluca_Lab2.Data.Arghiroiu_Raluca_Lab2Context _context;

        public IndexModel(Arghiroiu_Raluca_Lab2.Data.Arghiroiu_Raluca_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;
        public BookData BookData { get;set; }
        public int BookID { get; set; }
        public int CategoryID { get; set; }

        public async Task OnGetAsync(int? id, int? categoryId)
        {
            BookData = new BookData();

            BookData.Books = await _context.Book
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .Include(b => b.BookCategories)
                .ThenInclude(b => b.Category)
                .AsNoTracking()
                .OrderBy(b => b.Title)
                .ToListAsync();

            if (id != null)
            {
                BookID = id.Value;

                Book book = BookData.Books
                    .Where(b => b.ID == id.Value)
                    .Single();

                BookData.Categories = book.BookCategories.Select(b => b.Category);

            }
        }
    }
}
