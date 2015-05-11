using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorldsSmallestBookstore.Models
{
    public class Bookseller
    {
        [Key]
        public int BooksellerID { get; set; }

        public string Name { get; set; }
        public string password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public SellerTypes SellerType { get; set; }
    }

    public enum SellerTypes
    {
        Retail,
        Wholesale
    }
}

