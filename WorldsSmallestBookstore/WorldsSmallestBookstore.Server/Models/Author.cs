using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorldsSmallestBookstore.Models
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}