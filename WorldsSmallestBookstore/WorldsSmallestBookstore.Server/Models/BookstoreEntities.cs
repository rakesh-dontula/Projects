using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WorldsSmallestBookstore.Server.Models;

namespace WorldsSmallestBookstore.Models
{
    public class BookstoreEntities : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Bookseller> Booksellers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Customer> Customers { get; set; }

        // public DbSet<Books> Genres { get; set; }
    }
}

