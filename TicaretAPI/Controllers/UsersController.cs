using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretAPI.Models;

namespace TicaretAPI.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly UsersRepository usersRepository;

        public UsersController()
        {
            usersRepository = new UsersRepository();
        }
        [HttpGet("GetAll")]
        public IEnumerable<Users> Get()
        {
            return usersRepository.GetAllUser();
        }

        [HttpGet("GetById")]
        public Users Get(/*int id*/[FromBody] Users user)
        {
            var userid = user.userid;
            return usersRepository.GetById(userid);
        }

        [HttpGet("GetByUser")]
        public Users GetByUser(/*string username, string password*/ [FromBody] Users user)
        {
            //var username = user.username;
            //var password = user.password;
            return usersRepository.GetByUser(user.username, user.password);
        }

        [HttpGet("FindUser")]
        public Users FindUser(/*string username, string password*/ [FromBody] Users user)
        {
            //var username = user.username;
            //var password = user.password;
            var result = usersRepository.FindUser(user.username, user.password);
            return result;
        }

        [HttpGet("FindEmail")]
        public Users FindEmail(/*string username, string password*/ [FromBody] Users user)
        {
            //var username = user.username;
            //var password = user.password;
            var result = usersRepository.FindEmail(user.email);
            return result;
        }

        [HttpPost]
        public void Post([FromBody] Users user)
        {
            //prod.ProductId = id;

            if (ModelState.IsValid)
                usersRepository.AddUser(user);
        }

        [HttpPut("UpdateUser")]
        public void Put(/*int id,*/ [FromBody] Users user)
        {
            //user.id = id;
            if (ModelState.IsValid)
                usersRepository.UpdateUser(/*id,*/user);
        }

        [HttpDelete]
        public void Delete([FromBody] Users user)
        {
            usersRepository.DeleteUser(user.userid);
        }
    }
}
