using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        public IProductRepository _repository ;

        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = _repository.Get(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
