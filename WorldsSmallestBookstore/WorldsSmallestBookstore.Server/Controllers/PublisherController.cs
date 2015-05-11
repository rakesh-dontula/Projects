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
    public class PublisherController : ApiController
    {
        // GET api/values
        public IEnumerable<Publisher> Get()
        {
            return Repository.GlobalInstance.Data.Publishers;
        }

        // GET api/values/5
        public Publisher Get(int id)
        {
            return new Publisher();
        }

        // POST api/values
        public void Post([FromBody]Publisher value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Publisher value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
