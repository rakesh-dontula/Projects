using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorldsSmallestBookstore.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public string Title { get; set; }
        //public int AuthorID { get; set; }
        public Author Author { get; set; }
        //public int PublisherID { get; set; }
        public Publisher Publisher { get; set; }

    }
}