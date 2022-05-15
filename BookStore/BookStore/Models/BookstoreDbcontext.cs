using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class BookstoreDbcontext:DbContext
    {
        public BookstoreDbcontext()
        {
        }

        public BookstoreDbcontext(DbContextOptions<BookstoreDbcontext> options):base(options)
        {

        }
        public DbSet <Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
