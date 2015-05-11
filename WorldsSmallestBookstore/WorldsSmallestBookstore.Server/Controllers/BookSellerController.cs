using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WorldsSmallestBookstore.Models;
using WorldsSmallestBookstore.Server.DataAccess;

namespace WorldsSmallestBookstore.Server.Controllers
{
    public class BookSellerController : ApiController
    {
        // GET api/values
        public IEnumerable<Bookseller> Get()
        {
            return Repository.GlobalInstance.Data.Booksellers;
        }

        // GET api/values/5
        public Bookseller Get(int id)
        {
            return new Bookseller();
        }

        // POST api/values
        public void Post([FromBody]Bookseller value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Bookseller value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
