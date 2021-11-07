using Microsoft.AspNetCore.Mvc;
using MobileShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Controllers
{
    public class DanhmucController : Controller
    {
        MobileShopContext db = new MobileShopContext();
        public IActionResult Index()
        {
           var danhmuc = db.Hangsanxuats.ToList();
            return PartialView(danhmuc);
        }
    }
}
