using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretAPI.Models;

namespace TicaretAPI.Controllers
{
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        private readonly ProductsRepository productsRepository;

        public ProductsController()
        {
            productsRepository = new ProductsRepository();
        }
        [HttpGet("GetAll")]
        public IEnumerable<ProductsWithStore> Get()
        {
            return productsRepository.GetAllProduct();
        }

        [HttpGet("GetByProduct")]
        public ProductsWithStore Get(/*int id*/[FromBody] ProductsWithStore products)
        {
            var Id = products.Id;
            return productsRepository.GetByProduct(Id);
        }

        [HttpPost]
        public void Post([FromBody] Products products)
        {
            //prod.ProductId = id;

            if (ModelState.IsValid)
                productsRepository.AddProduct(products);
        }

        [HttpPut]
        public void Put(int id, [FromBody] ProductsWithStore products)
        {
            //user.id = id;
            if (ModelState.IsValid)
                productsRepository.UpdateProduct(id, products);
        }

        [HttpDelete]
        public void Delete([FromBody] Products products)
        {
            productsRepository.DeleteProduct(products.Id);
        }
    }
}
