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
    public class AuthorsController : ApiController
    {
        // GET api/values
        public IEnumerable<Author> Get()
        {
            return Repository.GlobalInstance.Data.Authors;
        }

        // GET api/values/5
        public Author Get(int id)
        {
            return new Author();
        }

        // POST api/values
        public void Post([FromBody]Author value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Author value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
