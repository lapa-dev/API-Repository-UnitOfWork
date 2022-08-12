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
    public class ProductsUWController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductsUWController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/<ProductsUWController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _unitOfWork.Products.Get();
        }

        // GET api/<ProductsUWController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _unitOfWork.Products.Get(id);
        }

        // POST api/<ProductsUWController>
        [HttpPost]
        public void Post(Product product)
        {
            _unitOfWork.Products.Add(product);
            _unitOfWork.Save();
        }

        // PUT api/<ProductsUWController>/5
        [HttpPut("{id}")]
        public void Put(Product product)
        {
            _unitOfWork.Products.Update(product);
            _unitOfWork.Save();
        }

        // DELETE api/<ProductsUWController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _unitOfWork.Products.Remove(id);
        }
    }
}
