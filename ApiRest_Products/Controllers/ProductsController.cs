using Microsoft.AspNetCore.Mvc;
using Models.Data;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiRest_Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IRepository<Product> _repository;

        public ProductsController(IRepository<Product> repository)
        {
            _repository = repository;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _repository.Get();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _repository.Get(id);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post(Product product)
        {
            _repository.Add(product);
            _repository.Save();
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, Product product)
        {
            _repository.Update(product);
            _repository.Save();
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Remove(id);
            _repository.Save();
        }
    }
}
