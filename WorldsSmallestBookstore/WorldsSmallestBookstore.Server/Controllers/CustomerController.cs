using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WorldsSmallestBookstore.Models;
using WorldsSmallestBookstore.Server.DataAccess;
using WorldsSmallestBookstore.Server.Models;

namespace WorldsSmallestBookstore.Server.Controllers
{
    public class CustomerController : ApiController
    {
        // GET api/values
        public IEnumerable<Customer> Get()
        {
            return Repository.GlobalInstance.Data.Customers;
        }

        // GET api/values/5
        public Customer Get(int id)
        {
            return new Customer();
        }

        // POST api/values
        public void Post([FromBody]Customer value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Customer value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
