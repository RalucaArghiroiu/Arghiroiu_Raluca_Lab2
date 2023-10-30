using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Arghiroiu_Raluca_Lab2.Models;

namespace Arghiroiu_Raluca_Lab2.Data
{
    public class Arghiroiu_Raluca_Lab2Context : DbContext
    {
        public Arghiroiu_Raluca_Lab2Context (DbContextOptions<Arghiroiu_Raluca_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Arghiroiu_Raluca_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Arghiroiu_Raluca_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Arghiroiu_Raluca_Lab2.Models.Author>? Author { get; set; }
    }
}
