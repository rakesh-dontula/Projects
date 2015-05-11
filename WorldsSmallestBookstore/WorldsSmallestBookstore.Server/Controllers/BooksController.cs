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
    public class BooksController : ApiController
    {
        // GET api/values
        public IEnumerable<Book> Get()
        {
            var retVal = Repository.GlobalInstance.Data.Books.Include("Author").Include("Publisher");
            return retVal;
        }

        // GET api/values/5
        public Book Get(int id)
        {
            return new Book();
        }

        // POST api/values
        public void Post([FromBody]Book value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Book value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
