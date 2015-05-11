using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorldsSmallestBookstore.Server.Models
{
    public class CustomerDemographic
    {
        public CustomerDemographic()
        {
            Customers = new List<Customer>();
        }
                
        [Key]
        public string CustomerDemographicID { get; set; }

        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}