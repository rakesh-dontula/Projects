using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorldsSmallestBookstore.Models
{
    public class Publisher
    {
        [Key]
        public int PublisherID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}