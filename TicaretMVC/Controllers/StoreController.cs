using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using TicaretMVC.Models;
using TicaretMVC.Services;

namespace TicaretMVC.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStoreService _storeService;
        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            Store store = new Store();
            var degerler = await _storeService.GetAllStore();
            //ViewBag.deger = degerler;
            return View(degerler);
        }

        public IActionResult GetStore(Store store)
        {
            return View("GetStore",store);
        }

        [HttpGet]
        public IActionResult NewStore()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NewStore(Store store)
        {
            if (!ModelState.IsValid)
            {
                return View("NewStore");
            }
            await _storeService.InsertStore(new Store() {/* groupid = store.groupid, */groupname = store.groupname });
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateStore(Store store)
        {
            await _storeService.UpdateStore(new Store() { groupid = store.groupid, groupname = store.groupname });

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteStore(int groupid)
        {
            if (groupid > 0)
            {
                await _storeService.DeleteStore(groupid);
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DetailStore(int groupid)
        {
            var a = await _storeService.GetByStore(groupid);
            //ViewBag.a = a;
            return View(a);
        }

        public IActionResult BackPage()
        {
            return RedirectToAction("Index");
        }
    }
}
