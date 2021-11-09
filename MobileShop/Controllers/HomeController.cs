using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MobileShop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        MobileShopContext db = new MobileShopContext();
        public IActionResult Index()
        {
            ViewData["iphone"] = db.Sanphams.Where(n => n.Mahang == 2).Take(4).ToList();
            ViewData["samsung"] = db.Sanphams.Where(n => n.Mahang == 1).Take(4).ToList();
            ViewData["xiaomi"] = db.Sanphams.Where(n => n.Mahang == 3).Take(4).ToList();
            if(HttpContext.Session.GetString("UserSession") != null)
            TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            return View();
           
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
