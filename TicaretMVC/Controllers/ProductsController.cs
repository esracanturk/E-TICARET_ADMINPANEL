using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using TicaretMVC.Models;
using TicaretMVC.Services;

namespace TicaretMVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService _productService;
        private readonly IStoreService _storeService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private IHostingEnvironment _environment;

        public ProductsController(IProductsService productService, IStoreService storeService,
            IWebHostEnvironment webHostEnvironment, IHostingEnvironment environment)
        {
            _productService = productService;
            _storeService = storeService;
            _webHostEnvironment = webHostEnvironment;
            _environment = environment;
        }

        //[Authorize]
        public async Task<IActionResult> Index(string ara, ProductsWithStore product)
        {
            var model = await _productService.GetAllProduct(product);
            return View();
        }

        [Authorize]
        public async Task<IActionResult> GetAllProduct(ProductsWithStore product)
        {
            //int? id = HttpContext.Session.GetInt32("Id");
            //string? id = HttpContext.Session.GetString("Id").ToString();
            var a = await _productService.GetAllProduct(product);
            return View(a);
        }

        [HttpGet]
        public async Task<IActionResult> GetProduct(ProductsWithStore products)
        {
            int Id = products.Id;
            var degerler = await _storeService.GetAllStore();
            ViewBag.deger = degerler;
            var a = await _productService.GetByProduct(Id);
            return View(a);
        }

        [HttpGet]
        public async Task<IActionResult> NewProduct()
        {
            var degerler = await _productService.GetAllStore();
            //var degerler2 = await _productService.GetAllUser();
            //ViewBag.deger2 = degerler2;
            ViewBag.deger = degerler;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewProduct(ProductsWithStore product, IFormFile file)
        {
            if (file != null || file.Length > 0)
            {
                var imagePath = @"\ProductImage\Image\";
                var uploadPath = _environment.WebRootPath + imagePath;

                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath);
                }

                var uniqFileName = Guid.NewGuid().ToString();
                var filename = Path.GetFileName(uniqFileName + "." + file.FileName.Split(".")[1].ToLower());
                var fullPath = uploadPath + filename;

                imagePath = imagePath + @"\";
                var filePath = @".." + Path.Combine(imagePath, filename);
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }

                await _productService.InsertProduct(new ProductsWithStore()
                {
                    /*Id = gelenData.Id,*/
                    Id = product.Id,
                    Name = product.Name,
                    Quantity = product.Quantity,
                    Price = product.Price,
                    ImageUrl = filePath,
                    Description = product.Description,
                    groupid = product.groupid,
                    groupname = product.groupname
                    //KategoriID=product.KategoriID,
                    //KategoriName = product.KategoriName
                });
                ViewData["FileLocation"] = filePath;
                var a = filePath;
                return RedirectToAction("GetAllProduct");
                //return View();
                //return RedirectToAction("Ekle","Product",filePath);
            }

            //if (!ModelState.IsValid)
            //{
            //    return RedirectToAction("NewProduct");
            //}
            ////Depart depart = new Depart();
            ////List<SelectListItem> degerler=(from x in depart.ToList())
            //await _productService.InsertProduct(new ProductsWithStore()
            //{
            //    Id = product.Id,
            //    Name = product.Name,
            //    Quantity = product.Quantity,
            //    Price = product.Price,
            //    ImageUrl = product.ImageUrl,
            //    Description = product.Description,
            //    groupid = product.groupid,
            //    groupname = product.groupname
            //});
            return RedirectToAction("GetAllProduct");
        }


        [HttpPost]
        public async Task<IActionResult> ProductUpdate(ProductsWithStore product,IFormFile file)
        {
            var Id = product.Id;
            if (file != null && file.Length > 0)
            {
                var imagePath = @"\ProductImage\Image\";
                var uploadPath = _environment.WebRootPath + imagePath;

                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath);
                }

                var uniqFileName = Guid.NewGuid().ToString();
                var filename = Path.GetFileName(uniqFileName + "." + file.FileName.Split(".")[1].ToLower());
                var fullPath = uploadPath + filename;

                imagePath = imagePath + @"\";
                var filePath = @".." + Path.Combine(imagePath, filename);
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }

                await _productService.UpdateProduct(Id,new ProductsWithStore()
                {
                    //Id = Id,
                    Name = product.Name,
                    Quantity = product.Quantity,
                    Price = product.Price,
                    ImageUrl = filePath,
                    Description = product.Description,
                    groupid = product.groupid,
                    groupname = product.groupname
                    //KategoriID = product.KategoriID,
                    //KategoriName = product.KategoriName
                });
                ViewData["FileLocation"] = filePath;
                var a = filePath;
                return RedirectToAction("GetAllProduct", "Products", a);
            }

            else
            {
                var a=await _productService.GetByProduct(Id);
                await _productService.UpdateProduct(Id, new ProductsWithStore()
                {
                    //Id = Id,
                    Name = product.Name,
                    Quantity = product.Quantity,
                    Price = product.Price,
                    ImageUrl = a.ImageUrl,
                    Description = product.Description,
                    groupid = product.groupid,
                    groupname = product.groupname
                    //KategoriID = product.KategoriID,
                    //KategoriName = product.KategoriName
                });
                return RedirectToAction("GetAllProduct", "Products");
            }

            return RedirectToAction("GetAllProduct");
            //await _productService.UpdateProduct(new ProductsWithStore()
            //{
            //    Id = product.Id,
            //    Name = product.Name,
            //    Quantity = product.Quantity,
            //    Price = product.Price,
            //    ImageUrl = product.ImageUrl,
            //    Description = product.Description,
            //    groupid = product.groupid,
            //    groupname = product.groupname
            //});

            //return RedirectToAction("GetAllProduct");
        }
        public async Task<IActionResult> ProductDelete(int Id)
        {
            if (Id > 0)
            {
                await _productService.DeleteProduct(Id);
            }
            return RedirectToAction("GetAllProduct");
        }

        public async Task<IActionResult> DetailProduct(int Id)
        {
            var a = await _productService.GetByProduct(Id);
            //ViewBag.a = a;
            return View(a);
        }
        public IActionResult BackPage()
        {
            return RedirectToAction("GetAllProduct");
        }
    }
}
