using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretAPI.Models;

namespace TicaretAPI.Controllers
{
    [Route("[controller]")]
    public class StoreController : Controller
    {
        private readonly StoreRepository storeRepository;

        public StoreController()
        {
            storeRepository = new StoreRepository();
        }

        [HttpGet("GetAll")]
        public IEnumerable<Store> Get()
        {
            return storeRepository.GetAllStore();
        }

        [HttpGet("GetByStore")]
        public Store Get(/*int id*/[FromBody] Store store)
        {
            var groupid = store.groupid;
            return storeRepository.GetByStore(groupid);
        }

        [HttpPost]
        public void Post([FromBody] Store store)
        {
            //prod.ProductId = id;

            if (ModelState.IsValid)
                storeRepository.AddStore(store);
        }

        [HttpPut]
        public void Put(/*int id,*/ [FromBody] Store store)
        {
            //user.id = id;
            if (ModelState.IsValid)
                storeRepository.UpdateStore(/*id,*/store);
        }

        [HttpDelete]
        public void Delete([FromBody] Store store)
        {
            storeRepository.DeleteStore(store.groupid);
        }
    }
}
