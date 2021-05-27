using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using TicaretMVC.Models;
using TicaretMVC.Services;

namespace TicaretMVC.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        private readonly IUsersService _userService;
        public UsersController(IUsersService userService)
        {
            _userService = userService;
        }

       
        //[Authorize(Roles = "admin")]
        public async Task<IActionResult> Index(string ara)
        {
            Users user = new Users();
            var degerler = await _userService.GetAllUser();
            //ViewBag.deger = degerler;
            return View(degerler);
        }

        public async Task<IActionResult> GetUser(Users user)
        {
            //int? id = HttpContext.Session.GetInt32("Id");
            //var degerler = await _userService.GetAllStore();
            //ViewBag.deger = degerler;
            //var degerler = await _userService.GetAllUser();
            //ViewBag.deger = degerler;
            var degerler1 = true;
            var degerler2 = false;
            ViewBag.deger2 = degerler2;
            ViewBag.deger1 = degerler1;
            return View("GetUser", user);
        }

        [HttpGet]
        public async Task<IActionResult> NewUser()
        {
            //var degerler = await _userService.GetAllStore();
            //var degerler2 = await _userService.GetAllUser();
            var degerler1 = true;
            var degerler2 = false;
            ViewBag.deger2 = degerler2;
            ViewBag.deger1 = degerler1;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewUser(Users user)
        {
            //if (!ModelState.IsValid)
            //{
            //    return RedirectToAction("NewUser");
            //}
            await _userService.InsertUser(new Users()
            {
                userid = user.userid,
                username = user.username,
                password = user.password,
                role = user.role,
                email=user.email,
                emailconfirm=user.emailconfirm
            });
            return RedirectToAction("Index");
        }

        //[HttpGet]
        public async Task<IActionResult> UpdateUser(Users user)
        {
            await _userService.UpdateUser(new Users()
            {
                userid = user.userid,
                username = user.username,
                password = user.password,
                role = user.role,
                email = user.email,
                emailconfirm = user.emailconfirm
            });
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteUser(int userid)
        {
            if (userid > 0)
            {
                await _userService.DeleteUser(userid);
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DetailUser(int userid)
        {
            var a = await _userService.GetByUser(userid);
            //ViewBag.a = a;
            return View(a);
        }

        public IActionResult BackPage()
        {
            return RedirectToAction("Index");
        }
    }
}
