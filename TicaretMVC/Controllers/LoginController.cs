using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using TicaretMVC.Models;
using TicaretMVC.Services;

namespace TicaretMVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsersService _userService;
        public LoginController(IUsersService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Users user)
        {
            var a = await _userService.FindUser(user);
            //List<UserWithDepart> lst = new List<UserWithDepart>();

            //return View("../User/Index");

            if (a == null) /* Kullanıcı veritabanında kayıtlı değil*/
            {
                //return RedirectToAction("Errorr", "Home");
                //ViewBag.Error = "404 NOTFOUND";
            }
            else
            {
                if (a.role == true) /* Kullanıcı veritabanında kayıtlı ve role=1 */
                {
                    var claims = new List<Claim>();
                    claims.Add(new Claim("username", a.username));
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, a.username));
                    claims.Add(new Claim(ClaimTypes.Name, a.username));
                    CookieOptions cookieOptions = new CookieOptions();
                    cookieOptions.Expires = DateTime.Now.AddDays(1);
                    HttpContext.Session.SetString("username", a.username);
                    HttpContext.Session.SetString("role", a.role.ToString());
                    HttpContext.Session.SetString("Id", a.userid.ToString());
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    return RedirectToAction("Index", "Users");

                    /* ********************* */
                    //string key = user.username;
                    //string value = user.password;
                    //CookieOptions cookieOptions = new CookieOptions();
                    //cookieOptions.Expires = DateTime.Now.AddDays(1);
                    //HttpContext.Session.SetString("username", a.username);
                    //HttpContext.Session.SetString("role", a.role.ToString());
                    //HttpContext.Session.SetString("Id", a.userid.ToString());
                    //Response.Cookies.Append(key, value, cookieOptions);
                    //var claims = new List<Claim>
                    //{
                    //    new Claim(ClaimTypes.Name,a.username)
                    //};
                    //var useridentity = new ClaimsIdentity(claims, "Login");
                    ////ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    //ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    //await HttpContext.SignInAsync(principal);
                    //return RedirectToAction("Index", "Users");
                    /* ********************* */
                }
                else /* Kullanıcı veritabanında kayıtlı ve role=0 */
                {
                    var claims = new List<Claim>();
                    claims.Add(new Claim("username", a.username));
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, a.username));
                    claims.Add(new Claim(ClaimTypes.Name, a.username));
                    CookieOptions cookieOptions = new CookieOptions();
                    cookieOptions.Expires = DateTime.Now.AddDays(1);
                    HttpContext.Session.SetString("username", a.username);
                    HttpContext.Session.SetString("role", a.role.ToString());
                    HttpContext.Session.SetString("Id", a.userid.ToString());
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);

                    /* ********************* */
                    //string key = user.username;
                    //string value = user.password;
                    //CookieOptions cookieOptions = new CookieOptions();
                    //cookieOptions.Expires = DateTime.Now.AddMinutes(10);
                    //Response.Cookies.Append(key, value, cookieOptions);
                    //var claims = new List<Claim>
                    //{
                    //    new Claim(ClaimTypes.Name,a.username)
                    //};
                    //var useridentity = new ClaimsIdentity(claims, "Login");
                    //ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    //await HttpContext.SignInAsync(principal);
                    /* ********************* */
                }
            }
            TempData["Error"] = "Kullanıcı adı veya şifre hatalı !!";
            return RedirectToAction("Login", "Login");
        }

        //[HttpGet]
        [Authorize]
        public async Task<IActionResult> LogOut(Users user)
        {
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("role");
            HttpContext.Session.Remove("Id");
            await HttpContext.SignOutAsync(/*(CookieAuthenticationDefaults.AuthenticationScheme)*/);
            //Response.Cookies.Delete(key);
            return Redirect("/");
        }

        //[HttpGet]
        //public async Task<IActionResult> LogOut(Users user)
        //{
        //    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        //    HttpContext.Session.Remove("username");
        //    HttpContext.Session.Remove("role");
        //    //Response.Cookies.Delete(key);
        //    return RedirectToAction("Login", "Login");
        //}

        //[HttpPost]
        //public async Task<IActionResult> Login(Users user)
        //{
        //    var a = await _userService.FindUser(user);
        //    var session = a.username;
        //    HttpContext.Session.SetString("username", session);
        //    //HttpContext.Session.SetString("role", a.role.ToString());
        //    if (a != null)
        //    {
        //        if (a.role == true)
        //        {
        //            return RedirectToAction("Index", "Users");
        //        }
        //        else
        //        {
        //            return RedirectToAction("Login", "Login");
        //        }
        //    }
        //    return RedirectToAction("Login", "Login");

        //}

        public async Task<IActionResult> Register()
        {
            //var degerler = await _userService.GetAllStore();
            //ViewBag.deger = degerler;
            var degerler2 = await _userService.GetAllUser();
            ViewBag.deger2 = degerler2;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Users user)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }
            await _userService.RegisterUser(new Users()
            {
                userid = user.userid,
                username = user.username,
                password = user.password,
                role = user.role,
                email = user.email,
                emailconfirm =user.emailconfirm
                });
            return RedirectToAction("Login", "Login");
        }

        public IActionResult BackPage()
        {
            return RedirectToAction("Login", "Login");
        }
    }
}
